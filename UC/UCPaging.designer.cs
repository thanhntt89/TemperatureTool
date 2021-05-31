namespace TemperatureTool.UC
{
    partial class UCPaging
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreviewous = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPreviewous
            // 
            this.btnPreviewous.Location = new System.Drawing.Point(39, 2);
            this.btnPreviewous.Name = "btnPreviewous";
            this.btnPreviewous.Size = new System.Drawing.Size(25, 26);
            this.btnPreviewous.TabIndex = 0;
            this.btnPreviewous.Text = "<";
            this.btnPreviewous.UseVisualStyleBackColor = true;
            this.btnPreviewous.Click += new System.EventHandler(this.btnPreviewous_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(501, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 26);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(70, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(425, 29);
            this.panelMain.TabIndex = 2;
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Location = new System.Drawing.Point(3, 5);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(30, 20);
            this.txtCurrentPage.TabIndex = 3;
            this.txtCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPage_KeyPress);
            // 
            // UCPaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPreviewous);
            this.Name = "UCPaging";
            this.Size = new System.Drawing.Size(528, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreviewous;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtCurrentPage;
    }
}
