using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TemperatureTool.Bussiness;
using TemperatureTool.Models;
using TemperatureTool.UC;
using TemperatureTool.Utilities;
using TemperatureTool.Utilitiess;
using static TemperatureTool.ApiClients.Actions.ClientActions;
using static TemperatureTool.ApiClients.Actions.ExportActions;

namespace TemperatureTool
{
    public partial class UCDataExtraction : UserControl
    {
        private RolesCollection rolesCollection = new RolesCollection();
        private RolesCollection rolesOutCollection = new RolesCollection();

        private DataExportCollection exportCollection = new DataExportCollection();
        private ClientCollection clientCollection = new ClientCollection();
        private CheckBox checkHeader = new CheckBox();
        private int CurrentPageIndex = 1;
        private HistoriesCollection historiesCollection = new HistoriesCollection();

        private int totalPage = 0;
        private int maxDisplayPages = 5;

        private BindingSource bindingSource = new BindingSource();
        private int startRowIndex = 0;

        private bool isAsc = true;
        private DataGridViewColumn preSortedColumn;
        private CSVExportBusiness exportBusiness = new CSVExportBusiness();
        private FileExport exportInfo = new FileExport();

        private BackgroundWorker bgwExport;
        private ProgresingBar progresingBar;

        public UCDataExtraction()
        {
            InitializeComponent();
            ucPaging.PageChangedSize += ResizePagin;
            ucPaging.PageClick += PageClicked;
            dtgResult.DataSource = bindingSource;
        }

        private void DisplayColumn()
        {
            if (rolesCollection == null) return;

            colDoB.Visible = rolesCollection.IsVisible(Constants.RoleSearchDoB);
            colEmail.Visible = rolesCollection.IsVisible(Constants.RoleSearchEmail);
            colName.Visible = rolesCollection.IsVisible(Constants.RoleSearchName);
            colPostNo.Visible = rolesCollection.IsVisible(Constants.RoleSearchZipCode);
            colSN.Visible = rolesCollection.IsVisible(Constants.RoleSearchSandD);
        }

        private void CreateCheckAll()
        {
            Point poit = dtgResult.GetCellDisplayRectangle(colCheck.DisplayIndex, -1, true).Location;
            checkHeader.BackColor = Color.Transparent;
            checkHeader.Size = new Size(14, 18);
            checkHeader.Location = new Point(poit.X + 8, poit.Y + 2);
            checkHeader.Click += checkHeader_Click;
            dtgResult.Controls.Add(checkHeader);
        }

        private void checkHeader_Click(object sender, EventArgs e)
        {
            clientCollection.SetCheckStatus(checkHeader.Checked);
            dtgResult.Refresh();
        }

        private void ResizePagin()
        {
            ucPaging.Location = new Point(this.Width - ucPaging.Size.Width - 5, ucPaging.Location.Y);
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = 1;

            SaveSearchingHistories();

            Searching(CurrentPageIndex, true);

            // Sort Id column
            clientCollection.Sort(dtgResult.Columns[colId.Name].DataPropertyName, SortOrder.Ascending);
        }

        private void SaveSearchingHistories()
        {
            try
            {
                SearchFieldCollection fieldCollection = new SearchFieldCollection();

                foreach (DataGridViewRow row in dtgRoleSearch.Rows)
                {
                    if (row.Cells[colValue.Name].Value == null)
                        continue;

                    fieldCollection.Add(new SearchField()
                    {
                        FieldName = row.Cells[colRoleName.Name].Value.ToString(),
                        Value = row.Cells[colValue.Name].Value.ToString(),
                        IsAnd = (bool)row.Cells[colIsAnd.Name].Value
                    });
                }

                historiesCollection.Add(fieldCollection);
                //Save to file
                FilesUtils.SerializeObject<HistoriesCollection>(historiesCollection, Constants.SearchingHistoriesFilePath);
            }
            catch (Exception ex)
            {

            }
        }

        private void SetSearchingHistories(string Id)
        {
            try
            {
                //LoadHistories
                historiesCollection = FilesUtils.DeSerializeObject<HistoriesCollection>(Constants.SearchingHistoriesFilePath);
                SearchFieldCollection searchFieldCollection = historiesCollection.GetSearchFieldCollection(Id);
                if (searchFieldCollection == null)
                    return;

                foreach (DataGridViewRow row in dtgRoleSearch.Rows)
                {
                    row.Cells[colValue.Name].Value = searchFieldCollection.GetField(row.Cells[colRoleName.Name].Value.ToString()).Value;
                    row.Cells[colIsAnd.Name].Value = searchFieldCollection.GetField(row.Cells[colRoleName.Name].Value.ToString()).IsAnd;
                }
            }
            catch (Exception ex)
            {
                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "SetSearchingHistories",
                    UserName = Constants.LoginName,
                    Notes = string.Format("Error:{0}", ex.Message)
                });
            }
        }

        private void Searching(int pageIndex, bool isCreateNew = false)
        {
            try
            {
                SearchClientsRequest req = new SearchClientsRequest()
                {
                    current_page = pageIndex,
                    birth = rolesCollection.IsVisible(Constants.RoleSearchDoB) ? rolesCollection.GetRole(Constants.RoleSearchDoB).Value : string.Empty,
                    filter_birth = rolesCollection.IsVisible(Constants.RoleSearchDoB) ? (rolesCollection.IsNotNullOrEmpty(Constants.RoleSearchDoB) ? rolesCollection.GetRole(Constants.RoleSearchDoB).IsAnd ? (int?)1 : (int?)0 : null) : null,
                    email = rolesCollection.IsVisible(Constants.RoleSearchEmail) ? rolesCollection.GetRole(Constants.RoleSearchEmail).Value : string.Empty,
                    filter_email = rolesCollection.IsVisible(Constants.RoleSearchEmail) ? (rolesCollection.IsNotNullOrEmpty(Constants.RoleSearchEmail) ? rolesCollection.GetRole(Constants.RoleSearchEmail).IsAnd ? (int?)1 : (int?)0 : null) : null,
                    name = rolesCollection.IsVisible(Constants.RoleSearchName) ? rolesCollection.GetRole(Constants.RoleSearchName).Value : string.Empty,
                    filter_name = rolesCollection.IsVisible(Constants.RoleSearchName) ? (rolesCollection.IsNotNullOrEmpty(Constants.RoleSearchName) ? rolesCollection.GetRole(Constants.RoleSearchName).IsAnd ? (int?)1 : (int?)0 : null) : null,
                    postno = rolesCollection.IsVisible(Constants.RoleSearchZipCode) ? rolesCollection.GetRole(Constants.RoleSearchZipCode).Value : string.Empty,
                    filter_postno = rolesCollection.IsVisible(Constants.RoleSearchZipCode) ? (rolesCollection.IsNotNullOrEmpty(Constants.RoleSearchZipCode) ? rolesCollection.GetRole(Constants.RoleSearchZipCode).IsAnd ? (int?)1 : (int?)0 : null) : null,
                    sn = rolesCollection.IsVisible(Constants.RoleSearchSandD) ? rolesCollection.GetRole(Constants.RoleSearchSandD).Value : string.Empty,
                    filter_sn = rolesCollection.IsVisible(Constants.RoleSearchSandD) ? (rolesCollection.IsNotNullOrEmpty(Constants.RoleSearchSandD) ? rolesCollection.GetRole(Constants.RoleSearchSandD).IsAnd ? (int?)1 : (int?)0 : null) : null,
                };

                SearchClientsResponse res = TemperatureSystem.iTemperatureClient.SearchClients(req);

                if (res.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    CurrentPageIndex = res.CurrentPage;
                    totalPage = res.TotalPage;
                    ucPaging.CreatePaging(totalPage, maxDisplayPages, CurrentPageIndex, isCreateNew);
                    if (rdNew.Checked)
                        clientCollection.Clients = res.Clients;
                    else if (rdAdd.Checked)
                        clientCollection.AddRanges(res.Clients);

                    bindingSource.DataSource = clientCollection.Clients;
                    bindingSource.ResetBindings(true);

                    lblRowTotal.Text = string.Format("合計:{0}", clientCollection.Count);
                    checkHeader_Click(null, null);
                }
                else if (res.Status.Equals(Constants.ResponseStatusFails))
                {
                    MessageBox.Show(res.ErrorInfo.Message, Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                dtgResult.Rows.Clear();
                lblRowTotal.Text = string.Empty;
                checkHeader.Checked = false;

                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "Search",
                    UserName = Constants.LoginName,
                    Notes = string.Format("Error:{0}", ex.Message)
                });
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanSearchInput();
        }

        private void CleanSearchInput()
        {
            foreach (DataGridViewRow row in dtgRoleSearch.Rows)
            {
                row.Cells[colValue.Name].Value = null;
                row.Cells[colIsAnd.Name].Value = false;
            }
        }

        private void btnHistories_Click(object sender, EventArgs e)
        {
            SearchingHistories searchingHistories = new SearchingHistories();
            searchingHistories.ShowDialog();
            SetSearchingHistories(searchingHistories.selectedId);
        }

        private void bntBrower_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "出力先を選択してください。";
            var rst = folderBrowser.ShowDialog();
            if (rst == DialogResult.OK)
            {
                txtFolderOutPut.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void ExecutingExport()
        {
            try
            {
                ExportRequest request = null;
                ExportResponse response = null;               
                //Check all
                if (rdBatchOutPut.Checked)
                {
                    Invoke(new Action(() =>
                    {
                        request = new ExportRequest()
                        {
                            Fields = GetExportFields(),
                            FromDate = dtStartDate.Text,
                            ToDate = dtEndDate.Text,
                            Users = clientCollection.GetSelectedUsers
                        };
                    }));

                    response = TemperatureSystem.iTemperatureClient.ExportCSV(request);
                    if (response.DataExports.Count == 0)
                    {
                        ClosedProgressBar();
                        Invoke(new Action(() =>
                        {                           
                            MessageBox.Show("該当データーがありません。", Constants.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }));

                        return;
                    }

                    exportCollection.ExportFileds = request.Fields.ToArray();
                    exportCollection.DataExports = response.DataExports;
                    exportBusiness.Export(exportCollection, exportInfo);                   
                }
                else
                {
                    int countCheck = 0;

                    foreach (string userId in clientCollection.GetSelectedUsers)
                    {
                        request = new ExportRequest()
                        {
                            Fields = GetExportFields(),
                            FromDate = dtStartDate.Text,
                            ToDate = dtEndDate.Text,
                            Users = new List<string> { userId }
                        };

                        response = TemperatureSystem.iTemperatureClient.ExportCSV(request);

                        if (response.DataExports.Count == 0)
                        {
                            continue;
                        }
                        countCheck++;
                        exportInfo.Suffix = userId;
                        exportCollection.ExportFileds = request.Fields.ToArray();
                        exportCollection.DataExports = response.DataExports;
                        exportBusiness.Export(exportCollection, exportInfo);                       
                    }

                    if (countCheck == 0)
                    {
                        ClosedProgressBar();
                        Invoke(new Action(() =>
                        {                           
                            MessageBox.Show("該当データーがありません。", Constants.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }));

                        return;
                    }
                }
                ClosedProgressBar();
                Invoke(new Action(() =>
                {
                    MessageBox.Show("ファイルを出力しました。", Constants.INFO_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            catch (Exception ex)
            {
                ClosedProgressBar();

                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "Search",
                    UserName = Constants.LoginName,
                    Notes = string.Format("Error:{0}", ex.Message)
                });

                Invoke(new Action(() =>
                {
                    MessageBox.Show(string.Format("File export fails!\nError:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private List<string> GetExportFields()
        {
            List<string> fields = new List<string>();
            Invoke(new Action(() =>
            {
                var fieldsChecked = ucRoleExport.GetFieldsChecked();
                //Get all DataExport properties
                PropertyAttributesCollection allProperties = typeof(DataExport).GetPropertiesAttributes();

                fields = (from r in allProperties.PropertyAttributes
                          join t in fieldsChecked
                          on r.Description equals t
                          select r.Name).ToList();
            }));
            return fields;
        }

        private void ShowProgressBar()
        {
            if (progresingBar == null)
            {
                progresingBar = new ProgresingBar();
            }
            progresingBar.ShowDialog();
        }

        private void ClosedProgressBar()
        {
            Invoke(new Action(() =>
            {
                if (progresingBar != null)
                {
                    progresingBar.Close();
                    progresingBar = null;
                }
            }));
        }

        private void Export()
        {
            if (!ValidExport())
                return;

            if (bgwExport == null)
            {
                bgwExport = new BackgroundWorker();
                bgwExport.RunWorkerCompleted += bgwExport_RunWorkerCompleted;
                bgwExport.DoWork += bgwExport_DoWork;
            }

            bgwExport.RunWorkerAsync();
            ShowProgressBar();
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            ExecutingExport();
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ClosedProgressBar();

            if (bgwExport != null)
            {
                bgwExport.Dispose();
                bgwExport = null;
            }
        }

        private bool ValidExport()
        {
            exportInfo = null;

            if (!FilesUtils.CheckFolderExist(txtFolderOutPut.Text))
            {
                txtFolderOutPut.Focus();
                MessageBox.Show(string.Format("{0}: {1} が存在しません。!", lblFolderOutput.Text, txtFolderOutPut.Text), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clientCollection.CountSeletedUsers == 0)
            {
                MessageBox.Show(string.Format("出力対象ユーザーを選択してください。"), Constants.INFO_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            exportInfo = new FileExport()
            {
                StartDateTime = DateTime.Now.ToString("yyyyMMddHHmm"),
                StartDate = dtStartDate.Value.ToString("yyyyMMdd"),
                EndDate = dtEndDate.Value.ToString("yyyyMMdd"),
                FolderPath = txtFolderOutPut.Text,
                Suffix = rdBatchOutPut.Checked ? Constants.Suffix_All : Constants.Suffix_UserId
            };
            return true;
        }

        private void UCDataExtraction_Load(object sender, EventArgs e)
        {
            LoadRoles();
            DisplayColumn();
            CreateCheckAll();
            btnClear_Click(null, null);
            LoadDefaultConfig();
        }

        private void LoadDefaultConfig()
        {
            try
            {
                txtFolderOutPut.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            catch (Exception ex)
            {
                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "LoadDefaultConfig",
                    UserName = Constants.LoginName,
                    Notes = string.Format("Error:{0}", ex.Message)
                });

                MessageBox.Show(string.Format("LoadDefaultConfig fails!\nError:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PageClicked(int pageIndex)
        {
            CurrentPageIndex = pageIndex;
            Searching(CurrentPageIndex);
        }

        private void LoadRoles()
        {
            UserInfo user = UserBusiness.GetUserById(Constants.LoginId);
            if (user == null)
                return;
            try
            {
                rolesCollection.Roles = user.Roles;
                rolesOutCollection.Roles = user.RolesOut;
                //Create check role export
                ucRoleExport.CreateRoles(rolesOutCollection);
                //Creare field role search
                dtgRoleSearch.DataSource = rolesCollection.GetRoles(true);
            }
            catch (Exception ex)
            {
                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "LoadRoles",
                    UserName = Constants.LoginName,
                    Notes = string.Format("Error:{0}", ex.Message)
                });

                MessageBox.Show(string.Format("Load roles fails!\nError:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dtgResult.AllowUserToAddRows && e.RowIndex > dtgResult.Rows.Count - 2)
                return;
            var grid = sender as DataGridView;

            startRowIndex = e.RowIndex + 1;

            var rowIdx = startRowIndex.ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,

                LineAlignment = StringAlignment.Center
            };
            //get the size of the string
            Size textSize = TextRenderer.MeasureText(rowIdx, this.Font);
            //if header width lower then string width then resize
            if (grid.RowHeadersWidth < textSize.Width + 40)
            {
                grid.RowHeadersWidth = textSize.Width + 40;
            }
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dtgResult_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgResult.Columns[e.ColumnIndex].SortMode == DataGridViewColumnSortMode.NotSortable)
                return;

            if (preSortedColumn != null && !preSortedColumn.Name.Equals(dtgResult.Columns[e.ColumnIndex].Name))
            {
                dtgResult.Columns[preSortedColumn.Name].HeaderCell.SortGlyphDirection = SortOrder.None;
                isAsc = false;
            }

            preSortedColumn = dtgResult.Columns[e.ColumnIndex];

            if (!isAsc)
            {
                clientCollection.Sort(dtgResult.Columns[e.ColumnIndex].DataPropertyName, SortOrder.Ascending);
                dtgResult.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                isAsc = true;
            }
            else
            {
                isAsc = false;
                clientCollection.Sort(dtgResult.Columns[e.ColumnIndex].DataPropertyName, SortOrder.Descending);
                dtgResult.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }

            dtgResult.Refresh();
        }

        private void dtgResult_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Point poit = dtgResult.GetCellDisplayRectangle(colCheck.DisplayIndex, -1, true).Location;
            checkHeader.Location = new Point(poit.X + (dtgResult.Columns[colCheck.DisplayIndex].Width - checkHeader.Width) / 2, poit.Y + 2);
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            clientCollection.Clear();
            bindingSource.ResetBindings(true);
            ucPaging.Clear();
            checkHeader.Checked = false;
            lblRowTotal.Text = string.Format("合計:{0}", clientCollection.Count);
        }
    }
}
