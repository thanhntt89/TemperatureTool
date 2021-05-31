namespace TemperatureTool.Users
{
    partial class AddUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.chkName = new System.Windows.Forms.CheckBox();
            this.chkDoB = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.chkSandN = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkZipCode = new System.Windows.Forms.CheckBox();
            this.chkDoBOut = new System.Windows.Forms.CheckBox();
            this.chkNameOut = new System.Windows.Forms.CheckBox();
            this.chkZipCodeOut = new System.Windows.Forms.CheckBox();
            this.chkEmailOut = new System.Windows.Forms.CheckBox();
            this.chkSandNOut = new System.Windows.Forms.CheckBox();
            this.grpSearchOut = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            this.grpSearchOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(15, 19);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(50, 17);
            this.chkName.TabIndex = 1;
            this.chkName.Text = "名前";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // chkDoB
            // 
            this.chkDoB.AutoSize = true;
            this.chkDoB.Location = new System.Drawing.Point(109, 19);
            this.chkDoB.Name = "chkDoB";
            this.chkDoB.Size = new System.Drawing.Size(74, 17);
            this.chkDoB.TabIndex = 2;
            this.chkDoB.Text = "生年月日";
            this.chkDoB.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(297, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "追加";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.chkSandN);
            this.grpSearch.Controls.Add(this.chkEmail);
            this.grpSearch.Controls.Add(this.chkZipCode);
            this.grpSearch.Controls.Add(this.chkName);
            this.grpSearch.Controls.Add(this.chkDoB);
            this.grpSearch.Location = new System.Drawing.Point(12, 40);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(361, 81);
            this.grpSearch.TabIndex = 6;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "検索・表示権限";
            // 
            // chkSandN
            // 
            this.chkSandN.AutoSize = true;
            this.chkSandN.Location = new System.Drawing.Point(109, 52);
            this.chkSandN.Name = "chkSandN";
            this.chkSandN.Size = new System.Drawing.Size(46, 17);
            this.chkSandN.TabIndex = 5;
            this.chkSandN.Text = "S/N";
            this.chkSandN.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(15, 52);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(90, 17);
            this.chkEmail.TabIndex = 4;
            this.chkEmail.Text = "メールアドレス";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkZipCode
            // 
            this.chkZipCode.AutoSize = true;
            this.chkZipCode.Location = new System.Drawing.Point(208, 19);
            this.chkZipCode.Name = "chkZipCode";
            this.chkZipCode.Size = new System.Drawing.Size(74, 17);
            this.chkZipCode.TabIndex = 3;
            this.chkZipCode.Text = "郵便番号";
            this.chkZipCode.UseVisualStyleBackColor = true;
            // 
            // chkDoBOut
            // 
            this.chkDoBOut.AutoSize = true;
            this.chkDoBOut.Location = new System.Drawing.Point(109, 19);
            this.chkDoBOut.Name = "chkDoBOut";
            this.chkDoBOut.Size = new System.Drawing.Size(74, 17);
            this.chkDoBOut.TabIndex = 2;
            this.chkDoBOut.Text = "生年月日";
            this.chkDoBOut.UseVisualStyleBackColor = true;
            // 
            // chkNameOut
            // 
            this.chkNameOut.AutoSize = true;
            this.chkNameOut.Location = new System.Drawing.Point(15, 19);
            this.chkNameOut.Name = "chkNameOut";
            this.chkNameOut.Size = new System.Drawing.Size(50, 17);
            this.chkNameOut.TabIndex = 1;
            this.chkNameOut.Text = "名前";
            this.chkNameOut.UseVisualStyleBackColor = true;
            // 
            // chkZipCodeOut
            // 
            this.chkZipCodeOut.AutoSize = true;
            this.chkZipCodeOut.Location = new System.Drawing.Point(208, 19);
            this.chkZipCodeOut.Name = "chkZipCodeOut";
            this.chkZipCodeOut.Size = new System.Drawing.Size(74, 17);
            this.chkZipCodeOut.TabIndex = 3;
            this.chkZipCodeOut.Text = "郵便番号";
            this.chkZipCodeOut.UseVisualStyleBackColor = true;
            // 
            // chkEmailOut
            // 
            this.chkEmailOut.AutoSize = true;
            this.chkEmailOut.Location = new System.Drawing.Point(15, 52);
            this.chkEmailOut.Name = "chkEmailOut";
            this.chkEmailOut.Size = new System.Drawing.Size(90, 17);
            this.chkEmailOut.TabIndex = 4;
            this.chkEmailOut.Text = "メールアドレス";
            this.chkEmailOut.UseVisualStyleBackColor = true;
            // 
            // chkSandNOut
            // 
            this.chkSandNOut.AutoSize = true;
            this.chkSandNOut.Location = new System.Drawing.Point(109, 52);
            this.chkSandNOut.Name = "chkSandNOut";
            this.chkSandNOut.Size = new System.Drawing.Size(46, 17);
            this.chkSandNOut.TabIndex = 5;
            this.chkSandNOut.Text = "S/N";
            this.chkSandNOut.UseVisualStyleBackColor = true;
            // 
            // grpSearchOut
            // 
            this.grpSearchOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearchOut.Controls.Add(this.chkSandNOut);
            this.grpSearchOut.Controls.Add(this.chkEmailOut);
            this.grpSearchOut.Controls.Add(this.chkZipCodeOut);
            this.grpSearchOut.Controls.Add(this.chkNameOut);
            this.grpSearchOut.Controls.Add(this.chkDoBOut);
            this.grpSearchOut.Location = new System.Drawing.Point(13, 127);
            this.grpSearchOut.Name = "grpSearchOut";
            this.grpSearchOut.Size = new System.Drawing.Size(360, 81);
            this.grpSearchOut.TabIndex = 6;
            this.grpSearchOut.TabStop = false;
            this.grpSearchOut.Text = "出力権限";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(70, 14);
            this.txtUserName.MaxLength = 7;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ログインID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(276, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "例: A123456";
            // 
            // AddUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpSearchOut);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpSearchOut.ResumeLayout(false);
            this.grpSearchOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.CheckBox chkDoB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.CheckBox chkSandN;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkZipCode;
        private System.Windows.Forms.CheckBox chkDoBOut;
        private System.Windows.Forms.CheckBox chkNameOut;
        private System.Windows.Forms.CheckBox chkZipCodeOut;
        private System.Windows.Forms.CheckBox chkEmailOut;
        private System.Windows.Forms.CheckBox chkSandNOut;
        private System.Windows.Forms.GroupBox grpSearchOut;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}