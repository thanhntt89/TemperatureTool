using System;
using System.Windows.Forms;
using TemperatureTool.Bussiness;
using TemperatureTool.Utilities;
using static TemperatureTool.ApiClients.Actions.UserActions;

namespace TemperatureTool.Users
{
    public partial class ChangePassword : Form
    {
        private bool _isChangePassword = false;
        private bool isSuccess = false;
        private string notes = string.Empty;

        public ChangePassword(bool isChangePassword)
        {
            InitializeComponent();
            _isChangePassword = isChangePassword;           
        }

        public ChangePassword()
        {
            InitializeComponent();
        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show(string.Format("旧パスワードを入力してください。"), Constants.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return false;
            }

            string currentPassword = UserBusiness.GetUserById(Constants.LoginId).Password;
            if (!currentPassword.Equals(txtCurrentPassword.Text))
            {
                MessageBox.Show(string.Format("旧パスワードを間違いました。"), Constants.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show(string.Format("新パスワードを入力してください。"), Constants.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show(string.Format("新パスワード(確認用)を入力してください。"), Constants.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }
            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show(string.Format("新パスワードと新パスワード(確認用)を一致しません。"), Constants.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            var rst = MessageBox.Show("パスワードを変更します。よろしいですか？", Constants.INFO_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst != DialogResult.Yes)
                return false;
            return true;
        }

        private void UserChangePassword()
        {
            if (!Valid())
                return;
            try
            {
                UserChangePasswordRequest request = new UserChangePasswordRequest()
                {
                    LoginId = Constants.LoginId,
                    OldPassword = txtCurrentPassword.Text,
                    NewPassword = txtNewPassword.Text
                };

                UserChangePasswordResponse response = UserBusiness.ChangePasswordResponse(request);

                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    notes = "Success";

                    MessageBox.Show("パスワードを変更しました。", Constants.INFO_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isSuccess = true;                   
                    btnClose_Click(null, null);
                }
                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    notes = "Fails";
                    MessageBox.Show(response.ErrorInfo.Message, Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                notes = "Fails";
                MessageBox.Show(string.Format("Error:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LogUtils.WriteLog(new LogInfo()
            {
                Action = "Change password",
                UserName = Constants.LoginName,
                Notes = notes
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_isChangePassword && !isSuccess)
            {
                Application.Exit();
            }
            else if (isSuccess)
            {
                this.Close();
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isChangePassword && !isSuccess)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_isChangePassword && !isSuccess)
            {
                Application.Exit();
            }
            else if (isSuccess)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserChangePassword();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Constants.LoginName;
        }
    }
}
