using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TemperatureTool.Models;

namespace TemperatureTool.UC
{
    public partial class UCRoleExport : UserControl
    {
        public UCRoleExport()
        {
            InitializeComponent();
        }

        public void CreateRoles(RolesCollection rolesCollection)
        {
            if (rolesCollection == null) 
                return;

            this.Controls.Clear();
            int column = 3;
            int max_with = 90;
            int heigth = 17;

            int maxColumn = this.Width / max_with;
            column = column > maxColumn ? column : maxColumn;
            int x = 4;
            int y = 3;
            int columnCount = 0;
            foreach (var role in rolesCollection.GetRoles(true))
            {
                columnCount++;
                //Next Row
                if (columnCount > column)
                {
                    //Reset X location
                    x = 4;
                    //Set Y
                    y += (heigth + 5);
                    columnCount = 0;
                }

                CheckBox check = new CheckBox();
                check.Name = string.Format("chk_{0}", role.RoleId);
                check.Text = role.RoleName;
                check.Location = new Point(x, y);
                this.Controls.Add(check);
                //Next X position
                x += (max_with + 14);
            }
        }

        public List<string> GetFieldsChecked()
        {
            return this.Controls.Cast<CheckBox>().Where(r => r.Checked).Select(r => r.Text).ToList<string>();
        }
    }

}
