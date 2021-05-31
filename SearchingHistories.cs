using System;
using System.Drawing;
using System.Windows.Forms;
using TemperatureTool.Utilities;

namespace TemperatureTool
{
    public partial class SearchingHistories : Form
    {
        public string selectedId = string.Empty;

        private HistoriesCollection historiesCollection = new HistoriesCollection();

        public SearchingHistories()
        {
            InitializeComponent();
        }

        private void SearchingHistories_Load(object sender, EventArgs e)
        {
            LoadHistories();
        }

        private void LoadHistories()
        {
            try
            {
                historiesCollection = SystemUtils.DeSerializeObject<HistoriesCollection > (Constants.SearchingHistoriesFilePath);
                historiesCollection.Sort("Id", SortOrder.Descending);
                dtgHistories.DataSource = historiesCollection.Histories;
            }
            catch (Exception ex)
            {
                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "LoadHistories",
                    UserName = Constants.LoginName,
                    Notes = string.Format("UserName:{0}\nFunction:{1}\nERROR!!!!", Constants.LoginName, "LoadHistories")
                });
            }
        }

        private void ResetHistories()
        {
            try
            {
                if (!dtgHistories.CurrentCell.OwningColumn.Name.Equals(colChoise.Name))
                    return;
                selectedId = dtgHistories.CurrentRow.Cells[colId.Name].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "LoadHistories",
                    UserName = Constants.LoginName,
                    Notes = string.Format("UserName:{0}\nFunction:{1}\nERROR!!!!", Constants.LoginName, "LoadHistories")
                });
            }
        }

        private void dtgHistories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetHistories();
        }

        private void dtgHistories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {           
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

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
    }
}
