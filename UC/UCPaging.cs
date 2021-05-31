using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TemperatureTool.UC
{
    public partial class UCPaging : UserControl
    {
        public delegate void PageClickedEvent(int pageIndex);
        public PageClickedEvent PageClick;
        public delegate void PageChangedSizeEvent();
        public PageChangedSizeEvent PageChangedSize;
        private List<Button> buttonList = new List<Button>();

        private const string ButtonPagingPreFix = "btn_Page";
        private int currentPageIndex = 0;
        private int maxDisplay = 2;
        private int totalPages = 100;
        private int pageTabIndex = 0;
        private int startPageIndex = 0;
        private int lastDisplayIndex = 0;

        public UCPaging()
        {
            InitializeComponent();
        }

        public void CreatePaging(int totalPages, int maxDisplay, int startIndex = 0, int currentPage = 1)
        {
            if (totalPages == 0)
                return;

            //Reset lable if next page
            if (panelMain.Controls.Count > 0)
            {
                SetPageLabel(currentPage, totalPages);
                return;
            }

            this.maxDisplay = maxDisplay;
            this.totalPages = totalPages;

            panelMain.Controls.Clear();
            buttonList.Clear();

            int pageIndex = 0;
            int tabIndex = btnPreviewous.TabIndex;
            maxDisplay = totalPages > maxDisplay ? maxDisplay : totalPages;

            int locationX = 3;
            int localtionY = 2;

            int btnW = 28;
            int btnH = 26;
            Button btn = null;

            while (pageIndex < maxDisplay)
            {
                pageIndex++;
                if (startIndex != 0)
                    startIndex++;
                else
                    startIndex = pageIndex;

                btn = new Button();
                btn.Name = string.Format("{0}{1}", ButtonPagingPreFix, startIndex);
                if (btn.Name.Equals(string.Format("{0}{1}", ButtonPagingPreFix, currentPage)))
                {
                    btn.Focus();
                    txtCurrentPage.Text = currentPage.ToString();
                }

                btn.Click += Page_Click;
                btn.Text = startIndex.ToString();
                btn.TabIndex = tabIndex++;

                btn.Size = new Size(btnW + 5, btnH);

                if (pageIndex == 1)
                {
                    btn.Location = new Point(locationX, localtionY);
                    btn.Focus();
                }
                else
                {
                    btn.Location = new Point(btn.Width * (pageIndex - 1) + locationX, localtionY);
                }

                //Add to list
                buttonList.Add(btn);

                panelMain.Controls.Add(btn);

                if (startPageIndex + tabIndex >= totalPages)
                    break;
            }

            //Sort button list
            buttonList.Sort(delegate (Button x, Button y)
            {
                return CompareInt(x, y);
            });

            if (currentPage == 1)
            {
                txtCurrentPage.Text = currentPage.ToString();
                Button button = GetButtonByIndex(currentPage);
                SetFontBold(button);
            }

            btnNext.TabIndex = tabIndex++;
            this.Width = btn.Width * (maxDisplay + 3) + txtCurrentPage.Width - btn.Width / 2;
            if (PageChangedSize != null)
                PageChangedSize();
        }

        public void Clear()
        {
            txtCurrentPage.Text = string.Empty;
            panelMain.Controls.Clear();
        }
            
        private int CompareInt(Button x, Button y)
        {
            int oX = int.Parse(x.Text);
            int oY = int.Parse(y.Text);
            return (oX < oY) ? -1 : ((oX == oY) ? 0 : 1);
        }

        private void SetPageLabel(int currentPage, int totalPages)
        {
            if (currentPage == 1)
            {
                txtCurrentPage.Text = currentPage.ToString();
                Button button = GetButtonByIndex(currentPage);
                SetFontBold(button);

                return;
            }

            if (buttonList.Count == 0)
                return;

            int startIndex = int.Parse(buttonList[0].Text);
            int lastIndex = int.Parse(buttonList[buttonList.Count - 1].Text);

            if (currentPage == lastIndex && lastIndex < totalPages)
                startIndex++;
            else if (currentPage == startIndex && startIndex > 1)
                startIndex--;
            else
                return;
            //Set page number
            foreach (Button button in buttonList)
            {
                button.Text = string.Format("{0}", startIndex);
                if (startIndex >= totalPages || startIndex < 0) break;

                startIndex++;
            }
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //Reset bot
            if (button != null)
            {
                currentPageIndex = int.Parse(button.Text);

                if (PageClick != null)
                    PageClick(currentPageIndex);
                txtCurrentPage.Text = button.Text;
                // Get current tab index
                pageTabIndex = button.TabIndex;
                SetFontBold(button);
            }
        }

        private void SetFontBold(Button button)
        {
            if (button == null)
                return;
            //Reset all           
            foreach (var btn in buttonList)
            {
                btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Regular);
            }

            button.Font = new Font(button.Font.Name, button.Font.Size, FontStyle.Bold);
        }

        private void btnPreviewous_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCurrentPage.Text) && this.IsNumeric(txtCurrentPage.Text))
                currentPageIndex = int.Parse(txtCurrentPage.Text);
            currentPageIndex--;
            if (currentPageIndex <= 0)
                currentPageIndex = 1;
            FocusPageByIndex(currentPageIndex);
            Button btn = GetButtonByIndex(currentPageIndex);
            if (btn != null)
                Page_Click(btn, null);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCurrentPage.Text) && this.IsNumeric(txtCurrentPage.Text))
                currentPageIndex = int.Parse(txtCurrentPage.Text);

            currentPageIndex++;
            if (currentPageIndex > totalPages)
                currentPageIndex = totalPages;

            FocusPageByIndex(currentPageIndex);
            Button btn = GetButtonByIndex(currentPageIndex);
            if (btn != null)
                Page_Click(btn, null);
        }

        private void FocusPageByIndex(int pageIndex)
        {
            Button btn = GetButtonByIndex(pageIndex);
            if (btn != null)
                btn.Focus();
        }

        private Button GetButtonByIndex(int pageIndex)
        {           
            return buttonList.Where(r => r.Text.Equals(string.Format("{0}", pageIndex))).FirstOrDefault();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                InputPageIndex();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void InputPageIndex()
        {
            if (!this.IsNumeric(txtCurrentPage.Text))
                return;
            currentPageIndex = int.Parse(txtCurrentPage.Text);
            if (currentPageIndex > totalPages)
            {
                MessageBox.Show("Current page larger than total page :" + totalPages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPage.SelectAll();
                txtCurrentPage.Focus();
                return;
            }
            if (PageClick != null)
                PageClick(currentPageIndex);

            FocusPageByIndex(currentPageIndex);
        }

        private void txtCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private bool IsNumeric(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
            return value.All(char.IsNumber);
        }
    }
}
