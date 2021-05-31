using System;
using System.Windows.Forms;
using TemperatureTool.Bussiness;
using TemperatureTool.Users;
using TemperatureTool.Utilities;
using static TemperatureTool.ApiClients.Actions.LoginActions;

namespace TemperatureTool
{
    public partial class Login : Form
    {
        public bool IsLoginSuccess = false;
        public LoginResponse loginResponse;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsLoginSuccess = Valid();
            if (IsLoginSuccess)
            {
                btnExit_Click(null, null);
            }
        }
             

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (IsLoginSuccess)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("ユーザー名を入力してください。", Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("パスワードを入力してください。", Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            string notes = string.Empty;

            try
            {
                LoginRequest request = new LoginRequest()
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text
                };

                loginResponse = UserBusiness.CheckLoginResponse(request);

                if (loginResponse.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    Constants.LoginId = loginResponse.UserId;
                    Constants.LoginName = txtUserName.Text;

                    if (loginResponse.ChangePasswordFlg == 1)
                    {
                        this.Hide();
                        ChangePassword changePassword = new ChangePassword(true);
                        changePassword.ShowDialog();
                    }
                    else
                        notes = "Success";
                }
                else if (loginResponse.Status.Equals(Constants.ResponseStatusFails) && loginResponse.ErrorInfo != null)
                {
                    if (loginResponse.ErrorInfo != null)
                        MessageBox.Show(loginResponse.ErrorInfo.Message, Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                notes = "Fails";
                //MessageBox.Show(string.Format("System error:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LogUtils.WriteLog(new LogInfo()
            {
                Action = "Login",
                UserName = Constants.LoginName,
                Notes = notes
            });
            return true;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoginSuccess)
                Application.Exit();
        }
    }
}
