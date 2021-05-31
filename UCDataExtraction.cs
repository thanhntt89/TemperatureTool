using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TemperatureTool.Bussiness;
using TemperatureTool.Models;
using TemperatureTool.Utilities;
using static TemperatureTool.ApiClients.Actions.ClientActions;
using static TemperatureTool.ApiClients.Actions.ExportActions;

namespace TemperatureTool
{
    public partial class UCDataExtraction : UserControl
    {
        private DataExportCollection exportCollection = new DataExportCollection();
        private ClientCollection clientCollection = new ClientCollection();
        private CheckBox checkHeader = new CheckBox();
        private int CurrentPageIndex = 1;
        private HistoriesCollection historiesCollection = new HistoriesCollection();

        private int totalPage = 0;
        private BindingSource bindingSource = new BindingSource();
        private int startRowIndex = 0;

        private bool isAsc = true;
        private DataGridViewColumn preSortedColumn;
        private CSVExportBusiness exportBusiness = new CSVExportBusiness();
        private FileExport exportInfo = new FileExport();

        public UCDataExtraction()
        {
            InitializeComponent();
            ucPaging.PageChangedSize += ResizePagin;
            ucPaging.PageClick += PageClicked;
            dtgResult.DataSource = bindingSource;
        }

        private void DisplayColumn()
        {
            colDoB.Visible = chkDoB.Visible;
            colEmail.Visible = chkEmail.Visible;
            colName.Visible = chkName.Visible;
            colPostNo.Visible = chkZipCode.Visible;
            colSN.Visible = chkSandN.Visible;
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
            Searching(CurrentPageIndex);

            // Sort Id column
            clientCollection.Sort(dtgResult.Columns[colId.Name].DataPropertyName, SortOrder.Ascending);
            SaveSearchingHistories();
        }

        private void SaveSearchingHistories()
        {
            try
            {
                SearchFieldCollection fieldCollection = new SearchFieldCollection();

                if (txtName.Visible && !string.IsNullOrWhiteSpace(txtName.Text.Trim()))
                    fieldCollection.Add(new SearchField()
                    {
                        FieldName = lblName.Text,
                        Value = txtName.Text,
                        IsAnd = chkName.Checked
                    });
                if (txtDoB.Visible && !string.IsNullOrWhiteSpace(txtDoB.Text.Trim()))
                    fieldCollection.Add(new SearchField()
                    {
                        FieldName = lblDoB.Text,
                        Value = txtDoB.Text,
                        IsAnd = chkDoB.Checked
                    });
                if (txtEmail.Visible && !string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
                    fieldCollection.Add(new SearchField()
                    {
                        FieldName = lblEmail.Text,
                        Value = txtEmail.Text,
                        IsAnd = chkEmail.Checked
                    });
                if (txtZipCode.Visible && !string.IsNullOrWhiteSpace(txtZipCode.Text.Trim()))
                    fieldCollection.Add(new SearchField()
                    {
                        FieldName = lblZipcode.Text,
                        Value = txtZipCode.Text,
                        IsAnd = chkZipCode.Checked
                    });
                if (txtSandN.Visible && !string.IsNullOrWhiteSpace(txtSandN.Text.Trim()))
                    fieldCollection.Add(new SearchField()
                    {
                        FieldName = lblSN.Text,
                        Value = txtSandN.Text,
                        IsAnd = chkSandN.Checked
                    });

                historiesCollection.Add(fieldCollection);

                //Save to file
                SystemUtils.SerializeObject<HistoriesCollection>(historiesCollection, Constants.SearchingHistoriesFilePath);
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
                historiesCollection = SystemUtils.DeSerializeObject<HistoriesCollection>(Constants.SearchingHistoriesFilePath);
                SearchFieldCollection searchFieldCollection = historiesCollection.GetSearchFieldCollection(Id);
                if (searchFieldCollection == null)
                    return;

                txtName.Text = searchFieldCollection.GetField(lblName.Text).Value;
                chkName.Checked = searchFieldCollection.GetField(lblName.Text).IsAnd;

                txtDoB.Text = searchFieldCollection.GetField(lblDoB.Text).Value;
                chkDoB.Checked = searchFieldCollection.GetField(lblDoB.Text).IsAnd;

                txtEmail.Text = searchFieldCollection.GetField(lblEmail.Text).Value;
                chkEmail.Checked = searchFieldCollection.GetField(lblEmail.Text).IsAnd;

                txtZipCode.Text = searchFieldCollection.GetField(lblZipcode.Text).Value;
                chkZipCode.Checked = searchFieldCollection.GetField(lblZipcode.Text).IsAnd;

                txtSandN.Text = searchFieldCollection.GetField(lblSN.Text).Value;
                chkSandN.Checked = searchFieldCollection.GetField(lblSN.Text).IsAnd;
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

        private void Searching(int pageIndex)
        {
            try
            {
                SearchClientsRequest req = new SearchClientsRequest()
                {
                    CurrentPage = pageIndex,
                    DoB = chkDoB.Visible ? txtDoB.Text : string.Empty,
                    FilterDoB = chkDoB.Visible ? chkDoB.Checked ? 1 : 0 : -1,//1:AND 0:OR -1:Not used condition
                    Email = chkEmail.Visible ? txtEmail.Text : string.Empty,
                    FilterEmail = chkEmail.Visible ? chkEmail.Checked ? 1 : 0 : -1,
                    Name = chkName.Visible ? txtName.Text : string.Empty,
                    FilterName = chkName.Visible ? chkName.Checked ? 1 : 0 : -1,
                    PostNo = chkZipCode.Visible ? txtZipCode.Text : string.Empty,
                    FilterPostNo = chkZipCode.Visible ? chkZipCode.Checked ? 1 : 0 : -1,
                    SN = chkSandN.Visible ? txtSandN.Text : string.Empty,
                    FilterSN = chkSandN.Visible ? chkSandN.Checked ? 1 : 0 : -1
                };

                SearchClientsResponse res = TemperatureSystem.iTemperatureClient.SearchClients(req);

                if (res.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    CurrentPageIndex = res.CurrentPage;
                    totalPage = res.TotalPage;
                    ucPaging.CreatePaging(totalPage, 10, 0, CurrentPageIndex);
                    clientCollection.Clients = res.Clients;
                    bindingSource.DataSource = clientCollection.Clients;
                    lblRowTotal.Text = string.Format("Total:{0}", clientCollection.Count);
                    checkHeader_Click(null, null);
                }
                else if (res.Status.Equals(Constants.ResponseStatusFails))
                {
                    MessageBox.Show(res.ErrorInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Clean();
        }

        private void Clean()
        {
            txtName.Text = string.Empty;
            txtDoB.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSandN.Text = string.Empty;
            txtZipCode.Text = string.Empty;

            chkDoB.Checked = false;
            chkEmail.Checked = false;
            chkName.Checked = false;
            chkSandN.Checked = false;
            chkZipCode.Checked = false;
            lblRowTotal.Text = string.Empty;
            dtgResult.Rows.Clear();
            ucPaging.Clear();
            checkHeader.Checked = false;
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

        private List<string> GetSelectedFields()
        {
            List<string> fields = new List<string>();
            if (chkNameOut.Checked)
                fields.Add("name");
            if (chkDoBOut.Checked)
                fields.Add("birthday");
            if (chkEmailOut.Checked)
                fields.Add("email");
            if (chkZipCodeOut.Checked)
                fields.Add("postno");
            if (chkSandNOut.Checked)
                fields.Add("sn");

            return fields;
        }

        private void Export()
        {
            if (!ValidExport())
                return;
            try
            {
                ExportRequest request = new ExportRequest()
                {
                    Fields = GetSelectedFields(),
                    FromDate = dtStartDate.Text,
                    ToDate = dtEndDate.Text,
                    Users = clientCollection.GetSelectedUsers()
                };

                ExportResponse response = TemperatureSystem.iTemperatureClient.ExportCSV(request);

                if (response.DataExports.Count == 0)
                {
                    MessageBox.Show("該当データーがありません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                exportCollection.ExportFileds = request.Fields.ToArray();
                exportCollection.DataExports = response.DataExports;                
                exportBusiness.Export(exportCollection, exportInfo);

                MessageBox.Show("File export successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "Search",
                    UserName = Constants.LoginName,
                    Notes = string.Format("Error:{0}", ex.Message)
                });

                MessageBox.Show(string.Format("File export fails!\nError:{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidExport()
        {
            exportInfo = null;

            if (!SystemUtils.CheckFolderExist(txtFolderOutPut.Text))
            {
                txtFolderOutPut.Focus();
                MessageBox.Show(string.Format("{0}: {1} が存在しません。!", lblFolderOutput.Text, txtFolderOutPut.Text), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clientCollection.CountSeletedUsers == 0)
            {
                MessageBox.Show(string.Format("出力対象ユーザーを選択してください。"), "情報", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            exportInfo = new FileExport()
            {
                StartDateTime = DateTime.Now.ToString("yyyyMMddHHmm"),
                StartDate = dtStartDate.Value.ToString("yyyyMMdd"),
                EndDate = dtEndDate.Value.ToString("yyyyMMdd"),
                FolderPath = txtFolderOutPut.Text,
                Suffix = rdBatchOutPut.Checked? Constants.Suffix_All: Constants.Suffix_UserId
            };
            return true;
        }

        private void UCDataExtraction_Load(object sender, EventArgs e)
        {
            LoadRoles();
            DisplayColumn();
            CreateCheckAll();
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
                txtDoB.Enabled = chkDoB.Enabled = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchDoB);
                lblDoB.Visible = chkDoB.Visible = txtDoB.Visible = chkDoB.Enabled;
                txtEmail.Enabled = chkEmail.Enabled = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchEmail);
                lblEmail.Visible = chkEmail.Visible = txtEmail.Visible = chkEmail.Enabled;
                txtName.Enabled = chkName.Enabled = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchName);
                lblName.Visible = txtName.Visible = chkName.Visible = chkName.Enabled;
                txtSandN.Enabled = chkSandN.Enabled = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchSandD);
                lblSN.Visible = chkSandN.Visible = txtSandN.Visible = chkSandN.Enabled;
                txtZipCode.Enabled = chkZipCode.Enabled = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchZipCode);
                lblZipcode.Visible = chkZipCode.Visible = txtZipCode.Visible = chkZipCode.Enabled;

                chkDoBOut.Enabled = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchDoB);
                chkDoBOut.Visible = chkDoBOut.Enabled;
                chkEmailOut.Enabled = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchEmail);
                chkEmailOut.Visible = chkEmailOut.Enabled;
                chkNameOut.Enabled = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchName);
                chkNameOut.Visible = chkNameOut.Enabled;
                chkSandNOut.Enabled = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchSandD);
                chkSandNOut.Visible = chkSandNOut.Enabled;
                chkZipCodeOut.Enabled = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchZipCode);
                chkZipCodeOut.Visible = chkZipCodeOut.Enabled;
            }
            catch
            {
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
    }
}
