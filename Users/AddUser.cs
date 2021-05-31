using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TemperatureTool.Bussiness;
using TemperatureTool.Models;
using TemperatureTool.Utilities;

namespace TemperatureTool.Users
{
    public partial class AddUser : Form
    {
        public delegate void ReLoadUserHandle();
        public ReLoadUserHandle ReLoadUserEvent;
        private int currentUserId = -1;
        private List<Role> roles = new List<Role>();
        private List<Role> rolesOutPut = new List<Role>();
        private string role = string.Empty;
        private string roleOut = string.Empty;

        public AddUser(int userId, string userName)
        {
            InitializeComponent();
            currentUserId = userId;
            txtUserName.Text = userName;
            txtUserName.ReadOnly = true;
            this.Text = "オペレーター管理画面";
            btnSave.Text = "変更";

            LoadUpdate(userId);
        }

        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentUserId == -1)
                AddUer();
            else
                UpdateUser();
        }

        private void LoadUpdate(int userId)
        {
            try
            {
                UserInfo user = UserBusiness.GetUserById(userId);

                chkDoB.Checked = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchDoB);
                chkEmail.Checked = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchEmail);
                chkName.Checked = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchName);
                chkSandN.Checked = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchSandD);
                chkZipCode.Checked = UserBusiness.CheckRoleExist(user.Roles, Constants.RoleSearchZipCode);


                chkDoBOut.Checked = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchDoB);
                chkEmailOut.Checked = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchEmail);
                chkNameOut.Checked = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchName);
                chkSandNOut.Checked = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchSandD);
                chkZipCodeOut.Checked = UserBusiness.CheckRoleExist(user.RolesOut, Constants.RoleSearchZipCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Update fails \nError:{0}", ex.Message), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            try
            {
                var rst = MessageBox.Show(string.Format("更新します、よろしいですか？"), Constants.INFO_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rst != DialogResult.Yes)
                {
                    this.Close();
                    return;
                }

                if (!Valid())
                    return;

                GetRoles();
                UserInfo user = new UserInfo()
                {
                    UserId = currentUserId,
                    Roles = roles,
                    RolesOut = rolesOutPut
                };

                UserBusiness.UpdateRole(user);

                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "UpdateUserRoles",
                    UserName = Constants.LoginName,
                    Notes = string.Format("UserName:{0}\nRoles:{1}\nRolesOut:{2}\nSuccess!!!!", txtUserName.Text, role, roleOut)
                });

                this.Close();
            }
            catch (Exception ex)
            {
                LogUtils.WriteLog(new LogInfo()
                {
                    Action = "UpdateUserRoles",
                    UserName = Constants.LoginName,
                    Notes = string.Format("UserName:{0}\nRoles:{1}\nRolesOut:{2}\nERROR!!!!", txtUserName.Text, role, roleOut)
                });
            }
        }

        private bool Valid()
        {
            if (currentUserId == -1)
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    MessageBox.Show(string.Format("ユーザーIDを入力してください。"), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return false;
                }

                if (!txtUserName.Text.Substring(0, 1).Contains("A"))
                {
                    MessageBox.Show(string.Format("ユーザーIDA+英数字を入力してください。"), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return false;
                }

                string number = txtUserName.Text.Substring(1);

                if (txtUserName.Text.Trim().Length < 7 || !Regex.IsMatch(number, @"^\d{6}"))
                {
                    MessageBox.Show(string.Format("ユーザーIDはをA+６英数字入力してください。"), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return false;
                }

                var userId = UserBusiness.GetUserIdByUserName(txtUserName.Text);
                if (userId != -1)
                {
                    MessageBox.Show(string.Format("ユーザーIDが重複しています。別のユーザーIDを入力してください。"), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return false;
                }
            }

            //Check count
            if (CountCheck(grpSearch) == 0)
            {
                MessageBox.Show(string.Format("検索表示権限に権限を選択してください。"), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CountCheck(grpSearchOut) == 0)
            {
                MessageBox.Show(string.Format("出力権限に権限を選択してください。"), Constants.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private int CountCheck(GroupBox group)
        {
            int count = 0;
            foreach (CheckBox check in group.Controls)
            {
                if (check.Checked)
                {
                    count++;
                }
            }

            return count;
        }

        private void ResetCheck(GroupBox group)
        {
            foreach (CheckBox check in group.Controls)
            {
                check.Checked = false;
            }
        }

        private void GetRoles()
        {

            if (chkName.Checked)
            {
                roles.Add(new Role()
                {
                    RoldeId = 1,
                    RoleName = Constants.RoleSearchName
                });
            }
            if (chkDoB.Checked)
            {
                roles.Add(new Role()
                {
                    RoldeId = 2,
                    RoleName = Constants.RoleSearchDoB
                });
            }
            if (chkZipCode.Checked)
            {
                roles.Add(new Role()
                {
                    RoldeId = 3,
                    RoleName = Constants.RoleSearchZipCode
                });
            }
            if (chkEmail.Checked)
            {
                roles.Add(new Role()
                {
                    RoldeId = 4,
                    RoleName = Constants.RoleSearchEmail
                });
            }
            if (chkSandN.Checked)
            {
                roles.Add(new Role()
                {
                    RoldeId = 5,
                    RoleName = Constants.RoleSearchSandD
                });
            }

            if (chkNameOut.Checked)
            {
                rolesOutPut.Add(new Role()
                {
                    RoldeId = 1,
                    RoleName = Constants.RoleSearchName
                });
            }
            if (chkDoBOut.Checked)
            {
                rolesOutPut.Add(new Role()
                {
                    RoldeId = 2,
                    RoleName = Constants.RoleSearchDoB
                });
            }
            if (chkZipCodeOut.Checked)
            {
                rolesOutPut.Add(new Role()
                {
                    RoldeId = 3,
                    RoleName = Constants.RoleSearchZipCode
                });
            }
            if (chkEmailOut.Checked)
            {
                rolesOutPut.Add(new Role()
                {
                    RoldeId = 4,
                    RoleName = Constants.RoleSearchEmail
                });
            }
            if (chkSandNOut.Checked)
            {
                rolesOutPut.Add(new Role()
                {
                    RoldeId = 5,
                    RoleName = Constants.RoleSearchSandD
                });
            }

            role = string.Join(", ", roles.Select(c => c.RoleName).ToArray<string>());
            roleOut = string.Join(", ", rolesOutPut.Select(c => c.RoleName).ToArray<string>());
        }

        private void AddUer()
        {
            if (!Valid())
                return;

            GetRoles();

            UserBusiness.Add(
                new UserInfo()
                {
                    UserName = txtUserName.Text,
                    Password = txtUserName.Text,
                    PasswordReset = 1,
                    Roles = roles,
                    RolesOut = rolesOutPut,
                    UpdateDate = DateTime.Now,
                    RegDate = DateTime.Now,
                    Authy = 2
                });

            txtUserName.Text = string.Empty;

            //Reset
            ResetCheck(grpSearch);
            ResetCheck(grpSearchOut);

            LogUtils.WriteLog(new LogInfo()
            {
                Action = "AddUser",
                UserName = Constants.LoginName,
                Notes = string.Format("UserName:{0}\nRoles:{1}\nRolesOut:{2}\nSuccess!!!!", txtUserName.Text, role, roleOut)
            });

            MessageBox.Show(string.Format("ユーザー登録が完了しました。", txtUserName.Text), Constants.INFO_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (ReLoadUserEvent != null)
                ReLoadUserEvent();

            txtUserName.Focus();
        }
    }
}
