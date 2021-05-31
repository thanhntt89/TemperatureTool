using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TemperatureTool.ApiClients;
using TemperatureTool.ApiClients.Config;
using TemperatureTool.ApiClients.Utilitiess;
using TemperatureTool.Bussiness;
using TemperatureTool.Models;
using TemperatureTool.Users;
using static TemperatureTool.ApiClients.Actions.LoginActions;

namespace TemperatureTool
{
    public partial class TemperatureToolMain : Form
    {
        private UserManagement userManagement;
        private UCDataExtraction uCDataExtraction;

        public TemperatureToolMain()
        {
            InitializeComponent();
            mnCreateList.Text = Constants.RoleCreatedList;
            mnExportdata.Text = Constants.RoleExportData;            
        }

        private void mnLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void mnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            ActiveLayout(login.loginResponse);
        }

        private void ActiveLayout(LoginResponse response)
        {
            if (response == null)
                return;

            mnLogin.Visible = false;

            mnLogout.Visible = true;
            mnChangePassword.Visible = response.AdminFlg == 1 ? false : true;
            lblLoginUserName.Text = Constants.LoginName;
          
            if(response.AdminFlg == 1)
            {
                mnCreateList_Click(null, null);
            }else
            {
                mnExportdata_Click(null, null);
            }
        }

        private void mnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void TemperatureToolMain_Load(object sender, EventArgs e)
        {
            LoadConfig();
            mnLogin_Click(null, null);
        }

        private void LoadConfig()
        {
            try
            {
                //Load UserList
                UserBusiness.Users = Utils.DeSerializeBinaryObject<List<UserInfo>>(Constants.UserDataPath);

                // Get config info
                ApiConfig apiConfig = Utils.DeSerializeObject<ApiConfig>(Constants.ConfigPath);

                ApiClient apiClient = new ApiClient(apiConfig.ApiInfos.ApiKey, apiConfig.ApiInfos.ApiSecret, apiConfig.ApiInfos.ApiUrl);
                TemperatureSystem.iTemperatureClient = new TemperatureClient(apiClient, apiConfig.EnpointInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Load config error:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void LogOut()
        {
            panelMain.Controls.Clear();
            uCDataExtraction = null;
            userManagement = null;

            mnLogin.Visible = true;
            mnChangePassword.Visible = false;
            mnLogout.Visible = false;           
            mnExportdata.Visible = false;
            mnCreateList.Visible = false;

            lblLoginUserName.Text = string.Empty;
            mnLogin_Click(null, null);
        }

        private void mnExportdata_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = true;

            if (uCDataExtraction == null)
                uCDataExtraction = new UCDataExtraction();

            AddControl(uCDataExtraction);
        }

        private void mnCreateList_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            if (userManagement == null)
                userManagement = new UserManagement();

            AddControl(userManagement);
        }

        private void AddControl(Control ctrl)
        {
            if (panelMain.Controls.Count > 0 && !panelMain.Controls[0].Name.Equals(ctrl.Name))
                panelMain.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            try
            {
                panelMain.Controls.Add(ctrl);
            }
            catch
            {
            }
        }
    }
}
