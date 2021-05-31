using System;
using System.Windows.Forms;
using TemperatureTool.Bussiness;
using static TemperatureTool.ApiClients.Actions.UserActions;

namespace TemperatureTool.Users
{
    public partial class UserManagement : UserControl
    {
        private int currentRowIndex = -1;

        public UserManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ReLoadUserEvent += LoadUsers;
            addUser.ShowDialog();
            if (dtgUser.Rows.Count > 0)
            {
                dtgUser.ClearSelection();
                dtgUser.Rows[dtgUser.Rows.Count - 1].Selected = true;
            }
        }

        private void LoadUsers()
        {
            try
            {
                dtgUser.DataSource = UserBusiness.GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void ResetPassWord()
        {
            if (!dtgUser.CurrentCell.OwningColumn.Name.Equals(colActionResetPassowrd.Name))
            {
                return;
            }

            int userId = dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserId.Name].Value == null ? -1 : Convert.ToInt32(dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserId.Name].Value);
            string userName = dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserName.Name].Value == null ? string.Empty : dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserName.Name].Value.ToString();

            var rst = MessageBox.Show(string.Format("リセットしてよろしいですか？", userName), Constants.INFO_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.No)
                return;

            try
            {
                UserResetPasswordRequest passwordRequest = new UserResetPasswordRequest()
                {
                    LoginId = Constants.LoginId,
                    UserId = userId
                };

                UserResetPasswordResponse response = UserBusiness.ResetPasswordResponse(passwordRequest);
                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    MessageBox.Show(string.Format("リセットしました。", userName), Constants.INFO_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    if (response.ErrorInfo != null)
                        MessageBox.Show(response.ErrorInfo.Message, Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("System error:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditUser()
        {
            if (!dtgUser.CurrentCell.OwningColumn.Name.Equals(colActionEdit.Name))
            {
                return;
            }

            int userId = dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserId.Name].Value == null ? -1 : Convert.ToInt32(dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserId.Name].Value.ToString());
            string userName = dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserName.Name].Value == null ? string.Empty : dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserName.Name].Value.ToString();

            AddUser addUser = new AddUser(userId, userName);
            addUser.ShowDialog();

            if (currentRowIndex != -1)
            {
                dtgUser.Rows[currentRowIndex].Selected = true;
            }
        }

        private void DeleteUser()
        {
            if (!dtgUser.CurrentCell.OwningColumn.Name.Equals(colActionDelete.Name))
            {
                return;
            }

            int userId = dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserId.Name].Value == null ? -1 : Convert.ToInt32(dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserId.Name].Value.ToString());
            string userName = dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserName.Name].Value == null ? string.Empty : dtgUser.Rows[dtgUser.CurrentRow.Index].Cells[colUserName.Name].Value.ToString();

            var rst = MessageBox.Show(string.Format("削除してよろしいですか？", userName), Constants.INFO_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.No)
                return;

            try
            {
                UserDeleteRequest request = new UserDeleteRequest()
                {
                    LoginId = Constants.LoginId,
                    UserId = userId
                };

                UserDeleteResponse response = UserBusiness.DeleteUserResponse(request);
                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    LoadUsers();
                    MessageBox.Show(string.Format("削除しました。", userName), Constants.INFO_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    MessageBox.Show(response.ErrorInfo.Message, Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("System error:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
            if (e.RowIndex == -1)
                return;

            ResetPassWord();
            EditUser();
            DeleteUser();
        }
    }
}
