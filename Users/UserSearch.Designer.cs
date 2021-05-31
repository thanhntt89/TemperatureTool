namespace TemperatureTool.Users
{
    partial class UserSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgUser = new System.Windows.Forms.DataGridView();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.btnSearchUserId = new System.Windows.Forms.Button();
            this.btnSearchNote = new System.Windows.Forms.Button();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCreateList);
            this.groupBox1.Controls.Add(this.btnSearchNote);
            this.groupBox1.Controls.Add(this.btnSearchUserId);
            this.groupBox1.Controls.Add(this.btnSearchUserName);
            this.groupBox1.Controls.Add(this.txtSearchValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtgUser
            // 
            this.dtgUser.AllowUserToAddRows = false;
            this.dtgUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colUserId,
            this.colName});
            this.dtgUser.Location = new System.Drawing.Point(12, 98);
            this.dtgUser.Name = "dtgUser";
            this.dtgUser.ReadOnly = true;
            this.dtgUser.Size = new System.Drawing.Size(776, 340);
            this.dtgUser.TabIndex = 5;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(6, 19);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(282, 20);
            this.txtSearchValue.TabIndex = 0;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Location = new System.Drawing.Point(6, 47);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(87, 23);
            this.btnSearchUserName.TabIndex = 1;
            this.btnSearchUserName.Text = "名前検索";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            // 
            // btnSearchUserId
            // 
            this.btnSearchUserId.Location = new System.Drawing.Point(106, 47);
            this.btnSearchUserId.Name = "btnSearchUserId";
            this.btnSearchUserId.Size = new System.Drawing.Size(94, 23);
            this.btnSearchUserId.TabIndex = 2;
            this.btnSearchUserId.Text = "USER ID検索";
            this.btnSearchUserId.UseVisualStyleBackColor = true;
            // 
            // btnSearchNote
            // 
            this.btnSearchNote.Location = new System.Drawing.Point(213, 47);
            this.btnSearchNote.Name = "btnSearchNote";
            this.btnSearchNote.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNote.TabIndex = 3;
            this.btnSearchNote.Text = "ALL";
            this.btnSearchNote.UseVisualStyleBackColor = true;
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(294, 47);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(88, 23);
            this.btnCreateList.TabIndex = 4;
            this.btnCreateList.Text = "リスト作成";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "チェック";
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 75;
            // 
            // colUserId
            // 
            this.colUserId.HeaderText = "USER ID";
            this.colUserId.Name = "colUserId";
            this.colUserId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUserId.Width = 150;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "名前";
            this.colName.Name = "colName";
            // 
            // CreateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateList";           
            this.Text = "わたしの温度 データ抽出ツール";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgUser;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Button btnSearchNote;
        private System.Windows.Forms.Button btnSearchUserId;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}