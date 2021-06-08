namespace TemperatureTool
{
    partial class UCDataExtraction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntBrower = new System.Windows.Forms.Button();
            this.txtFolderOutPut = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblFolderOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.rdIndividualOutPut = new System.Windows.Forms.RadioButton();
            this.rdBatchOutPut = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgRoleSearch = new System.Windows.Forms.DataGridView();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.btnHistories = new System.Windows.Forms.Button();
            this.btnClearCondition = new System.Windows.Forms.Button();
            this.btnSearching = new System.Windows.Forms.Button();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.rdNew = new System.Windows.Forms.RadioButton();
            this.dtgResult = new System.Windows.Forms.DataGridView();
            this.lblRowTotal = new System.Windows.Forms.Label();
            this.colSaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecureLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucPaging = new TemperatureTool.UC.UCPaging();
            this.ucRoleExport = new TemperatureTool.UC.UCRoleExport();
            this.colRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsAnd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoleSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucRoleExport);
            this.groupBox1.Controls.Add(this.bntBrower);
            this.groupBox1.Controls.Add(this.txtFolderOutPut);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.lblFolderOutput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.rdIndividualOutPut);
            this.groupBox1.Controls.Add(this.rdBatchOutPut);
            this.groupBox1.Location = new System.Drawing.Point(387, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 203);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "データ抽出";
            // 
            // bntBrower
            // 
            this.bntBrower.Location = new System.Drawing.Point(362, 145);
            this.bntBrower.Name = "bntBrower";
            this.bntBrower.Size = new System.Drawing.Size(44, 23);
            this.bntBrower.TabIndex = 26;
            this.bntBrower.Text = "参照";
            this.bntBrower.UseVisualStyleBackColor = true;
            this.bntBrower.Click += new System.EventHandler(this.bntBrower_Click);
            // 
            // txtFolderOutPut
            // 
            this.txtFolderOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderOutPut.Location = new System.Drawing.Point(81, 147);
            this.txtFolderOutPut.Name = "txtFolderOutPut";
            this.txtFolderOutPut.Size = new System.Drawing.Size(275, 20);
            this.txtFolderOutPut.TabIndex = 25;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExport.Location = new System.Drawing.Point(81, 174);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(325, 23);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "抽出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblFolderOutput
            // 
            this.lblFolderOutput.AutoSize = true;
            this.lblFolderOutput.Location = new System.Drawing.Point(6, 150);
            this.lblFolderOutput.Name = "lblFolderOutput";
            this.lblFolderOutput.Size = new System.Drawing.Size(43, 13);
            this.lblFolderOutput.TabIndex = 25;
            this.lblFolderOutput.Text = "出力先";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "付加出力";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "終了日付";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "形式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "開始日付";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy/MM/dd";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(282, 50);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(124, 20);
            this.dtEndDate.TabIndex = 19;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy/MM/dd";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(81, 50);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(124, 20);
            this.dtStartDate.TabIndex = 18;
            // 
            // rdIndividualOutPut
            // 
            this.rdIndividualOutPut.AutoSize = true;
            this.rdIndividualOutPut.Location = new System.Drawing.Point(179, 19);
            this.rdIndividualOutPut.Name = "rdIndividualOutPut";
            this.rdIndividualOutPut.Size = new System.Drawing.Size(73, 17);
            this.rdIndividualOutPut.TabIndex = 17;
            this.rdIndividualOutPut.Text = "個別出力";
            this.rdIndividualOutPut.UseVisualStyleBackColor = true;
            // 
            // rdBatchOutPut
            // 
            this.rdBatchOutPut.AutoSize = true;
            this.rdBatchOutPut.Checked = true;
            this.rdBatchOutPut.Location = new System.Drawing.Point(81, 19);
            this.rdBatchOutPut.Name = "rdBatchOutPut";
            this.rdBatchOutPut.Size = new System.Drawing.Size(73, 17);
            this.rdBatchOutPut.TabIndex = 16;
            this.rdBatchOutPut.TabStop = true;
            this.rdBatchOutPut.Text = "一括出力";
            this.rdBatchOutPut.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgRoleSearch);
            this.groupBox2.Controls.Add(this.btnClearResult);
            this.groupBox2.Controls.Add(this.btnHistories);
            this.groupBox2.Controls.Add(this.btnClearCondition);
            this.groupBox2.Controls.Add(this.btnSearching);
            this.groupBox2.Controls.Add(this.rdAdd);
            this.groupBox2.Controls.Add(this.rdNew);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索";
            // 
            // dtgRoleSearch
            // 
            this.dtgRoleSearch.AllowUserToAddRows = false;
            this.dtgRoleSearch.AllowUserToDeleteRows = false;
            this.dtgRoleSearch.AllowUserToResizeColumns = false;
            this.dtgRoleSearch.AllowUserToResizeRows = false;
            this.dtgRoleSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgRoleSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRoleSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRoleSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoleSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoleName,
            this.colValue,
            this.colIsAnd,
            this.colIsVisible,
            this.colRoleId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRoleSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRoleSearch.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtgRoleSearch.Location = new System.Drawing.Point(8, 36);
            this.dtgRoleSearch.MultiSelect = false;
            this.dtgRoleSearch.Name = "dtgRoleSearch";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRoleSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRoleSearch.RowHeadersVisible = false;
            this.dtgRoleSearch.Size = new System.Drawing.Size(364, 131);
            this.dtgRoleSearch.TabIndex = 17;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(110, 174);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(89, 23);
            this.btnClearResult.TabIndex = 13;
            this.btnClearResult.Text = "検索結果クリア ";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // btnHistories
            // 
            this.btnHistories.Location = new System.Drawing.Point(305, 174);
            this.btnHistories.Name = "btnHistories";
            this.btnHistories.Size = new System.Drawing.Size(67, 23);
            this.btnHistories.TabIndex = 15;
            this.btnHistories.Text = "履歴";
            this.btnHistories.UseVisualStyleBackColor = true;
            this.btnHistories.Click += new System.EventHandler(this.btnHistories_Click);
            // 
            // btnClearCondition
            // 
            this.btnClearCondition.Location = new System.Drawing.Point(207, 174);
            this.btnClearCondition.Name = "btnClearCondition";
            this.btnClearCondition.Size = new System.Drawing.Size(90, 23);
            this.btnClearCondition.TabIndex = 14;
            this.btnClearCondition.Text = "検索条件クリア";
            this.btnClearCondition.UseVisualStyleBackColor = true;
            this.btnClearCondition.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearching
            // 
            this.btnSearching.Location = new System.Drawing.Point(6, 174);
            this.btnSearching.Name = "btnSearching";
            this.btnSearching.Size = new System.Drawing.Size(96, 23);
            this.btnSearching.TabIndex = 12;
            this.btnSearching.Text = "検索";
            this.btnSearching.UseVisualStyleBackColor = true;
            this.btnSearching.Click += new System.EventHandler(this.btnSearching_Click);
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Location = new System.Drawing.Point(195, 14);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(49, 17);
            this.rdAdd.TabIndex = 1;
            this.rdAdd.Text = "追加";
            this.rdAdd.UseVisualStyleBackColor = true;
            // 
            // rdNew
            // 
            this.rdNew.AutoSize = true;
            this.rdNew.Checked = true;
            this.rdNew.Location = new System.Drawing.Point(106, 14);
            this.rdNew.Name = "rdNew";
            this.rdNew.Size = new System.Drawing.Size(49, 17);
            this.rdNew.TabIndex = 0;
            this.rdNew.TabStop = true;
            this.rdNew.Text = "新規";
            this.rdNew.UseVisualStyleBackColor = true;
            // 
            // dtgResult
            // 
            this.dtgResult.AllowUserToAddRows = false;
            this.dtgResult.AllowUserToDeleteRows = false;
            this.dtgResult.AllowUserToResizeRows = false;
            this.dtgResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colId,
            this.colName,
            this.colDoB,
            this.colPostNo,
            this.colEmail,
            this.colSN,
            this.colWeight,
            this.colHeight,
            this.colSecureLevel,
            this.colSaveDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgResult.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgResult.Location = new System.Drawing.Point(3, 212);
            this.dtgResult.MultiSelect = false;
            this.dtgResult.Name = "dtgResult";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgResult.Size = new System.Drawing.Size(804, 292);
            this.dtgResult.TabIndex = 28;
            this.dtgResult.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgResult_ColumnHeaderMouseClick);
            this.dtgResult.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dtgResult_ColumnWidthChanged);
            this.dtgResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgResult_RowPostPaint);
            // 
            // lblRowTotal
            // 
            this.lblRowTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowTotal.AutoSize = true;
            this.lblRowTotal.Location = new System.Drawing.Point(2, 508);
            this.lblRowTotal.Name = "lblRowTotal";
            this.lblRowTotal.Size = new System.Drawing.Size(16, 13);
            this.lblRowTotal.TabIndex = 30;
            this.lblRowTotal.Text = "...";
            // 
            // colSaveDate
            // 
            this.colSaveDate.DataPropertyName = "SaveDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSaveDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSaveDate.HeaderText = "年月日_SaveDate";
            this.colSaveDate.Name = "colSaveDate";
            this.colSaveDate.ReadOnly = true;
            this.colSaveDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSaveDate.Visible = false;
            this.colSaveDate.Width = 150;
            // 
            // colSecureLevel
            // 
            this.colSecureLevel.DataPropertyName = "SecureLevel";
            this.colSecureLevel.HeaderText = "SecureLevel";
            this.colSecureLevel.Name = "colSecureLevel";
            this.colSecureLevel.ReadOnly = true;
            this.colSecureLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSecureLevel.Visible = false;
            // 
            // colHeight
            // 
            this.colHeight.DataPropertyName = "Height";
            this.colHeight.HeaderText = "身長";
            this.colHeight.Name = "colHeight";
            this.colHeight.ReadOnly = true;
            this.colHeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colHeight.Visible = false;
            // 
            // colWeight
            // 
            this.colWeight.DataPropertyName = "Weight";
            this.colWeight.HeaderText = "目標体重";
            this.colWeight.Name = "colWeight";
            this.colWeight.ReadOnly = true;
            this.colWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colWeight.Visible = false;
            // 
            // colSN
            // 
            this.colSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSN.DataPropertyName = "SN";
            this.colSN.HeaderText = "S/N";
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            this.colSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "メールアドレス ";
            this.colEmail.MinimumWidth = 120;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colPostNo
            // 
            this.colPostNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPostNo.DataPropertyName = "PostNo";
            this.colPostNo.HeaderText = "郵便番号";
            this.colPostNo.Name = "colPostNo";
            this.colPostNo.ReadOnly = true;
            this.colPostNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colDoB
            // 
            this.colDoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDoB.DataPropertyName = "DoB";
            this.colDoB.HeaderText = "年月日";
            this.colDoB.Name = "colDoB";
            this.colDoB.ReadOnly = true;
            this.colDoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "名前";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "USER ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colCheck
            // 
            this.colCheck.DataPropertyName = "IsChecked";
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCheck.Width = 52;
            // 
            // ucPaging
            // 
            this.ucPaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPaging.Location = new System.Drawing.Point(473, 508);
            this.ucPaging.Name = "ucPaging";
            this.ucPaging.Size = new System.Drawing.Size(334, 28);
            this.ucPaging.TabIndex = 29;
            // 
            // ucRoleExport
            // 
            this.ucRoleExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRoleExport.Location = new System.Drawing.Point(81, 76);
            this.ucRoleExport.Name = "ucRoleExport";
            this.ucRoleExport.Size = new System.Drawing.Size(325, 65);
            this.ucRoleExport.TabIndex = 28;
            // 
            // colRoleName
            // 
            this.colRoleName.DataPropertyName = "RoleName";
            this.colRoleName.HeaderText = "";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.ReadOnly = true;
            this.colRoleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.DataPropertyName = "Value";
            this.colValue.HeaderText = "";
            this.colValue.Name = "colValue";
            this.colValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colIsAnd
            // 
            this.colIsAnd.DataPropertyName = "IsAnd";
            this.colIsAnd.HeaderText = "AND";
            this.colIsAnd.Name = "colIsAnd";
            this.colIsAnd.Width = 40;
            // 
            // colIsVisible
            // 
            this.colIsVisible.DataPropertyName = "IsVisible";
            this.colIsVisible.HeaderText = "IsVisible";
            this.colIsVisible.Name = "colIsVisible";
            this.colIsVisible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsVisible.Visible = false;
            // 
            // colRoleId
            // 
            this.colRoleId.DataPropertyName = "RoleId";
            this.colRoleId.HeaderText = "";
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.Visible = false;
            // 
            // UCDataExtraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblRowTotal);
            this.Controls.Add(this.ucPaging);
            this.Controls.Add(this.dtgResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCDataExtraction";
            this.Size = new System.Drawing.Size(810, 536);
            this.Load += new System.EventHandler(this.UCDataExtraction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoleSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdIndividualOutPut;
        private System.Windows.Forms.RadioButton rdBatchOutPut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHistories;
        private System.Windows.Forms.Button btnClearCondition;
        private System.Windows.Forms.Button btnSearching;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.RadioButton rdNew;
        private System.Windows.Forms.DataGridView dtgResult;
        private System.Windows.Forms.Button bntBrower;
        private System.Windows.Forms.TextBox txtFolderOutPut;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblFolderOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label5;
        private UC.UCPaging ucPaging;
        private System.Windows.Forms.Label lblRowTotal;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.DataGridView dtgRoleSearch;
        private UC.UCRoleExport ucRoleExport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecureLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsAnd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleId;
    }
}
