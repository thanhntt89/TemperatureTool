using System;
using System.Drawing;
using System.Windows.Forms;

namespace TemperatureTool.UC
{
    public partial class ProgresingBar : Form
    {
        public ProgresingBar()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            this.TransparencyKey = this.BackColor;
        }

        private void ProgresingBar_Load(object sender, EventArgs e)
        {
            circularProgressBar.Size = new Size(136, 136);
            this.Size = circularProgressBar.Size;
            circularProgressBar.Dock = DockStyle.Fill;
        }
    }
}
