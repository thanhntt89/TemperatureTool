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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntBrower = new System.Windows.Forms.Button();
            this.txtFolderOutPut = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblFolderOutput = new System.Windows.Forms.Label();
            this.chkSandNOut = new System.Windows.Forms.CheckBox();
            this.chkEmailOut = new System.Windows.Forms.CheckBox();
            this.chkZipCodeOut = new System.Windows.Forms.CheckBox();
            this.chkDoBOut = new System.Windows.Forms.CheckBox();
            this.chkNameOut = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.rdIndividualOutPut = new System.Windows.Forms.RadioButton();
            this.rdBatchOutPut = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHistories = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearching = new System.Windows.Forms.Button();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chkSandN = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkZipCode = new System.Windows.Forms.CheckBox();
            this.chkDoB = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.txtSandN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.rdNew = new System.Windows.Forms.RadioButton();
            this.dtgResult = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecureLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRowTotal = new System.Windows.Forms.Label();
            this.ucPaging = new TemperatureTool.UC.UCPaging();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntBrower);
            this.groupBox1.Controls.Add(this.txtFolderOutPut);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.lblFolderOutput);
            this.groupBox1.Controls.Add(this.chkSandNOut);
            this.groupBox1.Controls.Add(this.chkEmailOut);
            this.groupBox1.Controls.Add(this.chkZipCodeOut);
            this.groupBox1.Controls.Add(this.chkDoBOut);
            this.groupBox1.Controls.Add(this.chkNameOut);
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
            this.bntBrower.Location = new System.Drawing.Point(367, 119);
            this.bntBrower.Name = "bntBrower";
            this.bntBrower.Size = new System.Drawing.Size(45, 23);
            this.bntBrower.TabIndex = 26;
            this.bntBrower.Text = "参照";
            this.bntBrower.UseVisualStyleBackColor = true;
            this.bntBrower.Click += new System.EventHandler(this.bntBrower_Click);
            // 
            // txtFolderOutPut
            // 
            this.txtFolderOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderOutPut.Location = new System.Drawing.Point(86, 121);
            this.txtFolderOutPut.Name = "txtFolderOutPut";
            this.txtFolderOutPut.Size = new System.Drawing.Size(275, 20);
            this.txtFolderOutPut.TabIndex = 25;
            this.txtFolderOutPut.Text = "C:\\Work";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExport.Location = new System.Drawing.Point(86, 174);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(275, 23);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "抽出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblFolderOutput
            // 
            this.lblFolderOutput.AutoSize = true;
            this.lblFolderOutput.Location = new System.Drawing.Point(13, 124);
            this.lblFolderOutput.Name = "lblFolderOutput";
            this.lblFolderOutput.Size = new System.Drawing.Size(43, 13);
            this.lblFolderOutput.TabIndex = 25;
            this.lblFolderOutput.Text = "出力先";
            // 
            // chkSandNOut
            // 
            this.chkSandNOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSandNOut.AutoSize = true;
            this.chkSandNOut.Location = new System.Drawing.Point(183, 100);
            this.chkSandNOut.Name = "chkSandNOut";
            this.chkSandNOut.Size = new System.Drawing.Size(46, 17);
            this.chkSandNOut.TabIndex = 24;
            this.chkSandNOut.Text = "S/N";
            this.chkSandNOut.UseVisualStyleBackColor = true;
            // 
            // chkEmailOut
            // 
            this.chkEmailOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEmailOut.AutoSize = true;
            this.chkEmailOut.Location = new System.Drawing.Point(86, 100);
            this.chkEmailOut.Name = "chkEmailOut";
            this.chkEmailOut.Size = new System.Drawing.Size(90, 17);
            this.chkEmailOut.TabIndex = 23;
            this.chkEmailOut.Text = "メールアドレス";
            this.chkEmailOut.UseVisualStyleBackColor = true;
            // 
            // chkZipCodeOut
            // 
            this.chkZipCodeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkZipCodeOut.AutoSize = true;
            this.chkZipCodeOut.Location = new System.Drawing.Point(287, 77);
            this.chkZipCodeOut.Name = "chkZipCodeOut";
            this.chkZipCodeOut.Size = new System.Drawing.Size(74, 17);
            this.chkZipCodeOut.TabIndex = 22;
            this.chkZipCodeOut.Text = "郵便番号";
            this.chkZipCodeOut.UseVisualStyleBackColor = true;
            // 
            // chkDoBOut
            // 
            this.chkDoBOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDoBOut.AutoSize = true;
            this.chkDoBOut.Location = new System.Drawing.Point(183, 77);
            this.chkDoBOut.Name = "chkDoBOut";
            this.chkDoBOut.Size = new System.Drawing.Size(74, 17);
            this.chkDoBOut.TabIndex = 21;
            this.chkDoBOut.Text = "生年月日";
            this.chkDoBOut.UseVisualStyleBackColor = true;
            // 
            // chkNameOut
            // 
            this.chkNameOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNameOut.AutoSize = true;
            this.chkNameOut.Location = new System.Drawing.Point(86, 77);
            this.chkNameOut.Name = "chkNameOut";
            this.chkNameOut.Size = new System.Drawing.Size(50, 17);
            this.chkNameOut.TabIndex = 20;
            this.chkNameOut.Text = "名前";
            this.chkNameOut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "付加出力";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "終了日付";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "形式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "開始日付";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy/MM/dd";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(287, 50);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(124, 20);
            this.dtEndDate.TabIndex = 19;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy/MM/dd";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(86, 50);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(124, 20);
            this.dtStartDate.TabIndex = 18;
            // 
            // rdIndividualOutPut
            // 
            this.rdIndividualOutPut.AutoSize = true;
            this.rdIndividualOutPut.Location = new System.Drawing.Point(184, 19);
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
            this.rdBatchOutPut.Location = new System.Drawing.Point(86, 19);
            this.rdBatchOutPut.Name = "rdBatchOutPut";
            this.rdBatchOutPut.Size = new System.Drawing.Size(73, 17);
            this.rdBatchOutPut.TabIndex = 16;
            this.rdBatchOutPut.TabStop = true;
            this.rdBatchOutPut.Text = "一括出力";
            this.rdBatchOutPut.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHistories);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSearching);
            this.groupBox2.Controls.Add(this.lblSN);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblZipcode);
            this.groupBox2.Controls.Add(this.lblDoB);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.chkSandN);
            this.groupBox2.Controls.Add(this.chkEmail);
            this.groupBox2.Controls.Add(this.chkZipCode);
            this.groupBox2.Controls.Add(this.chkDoB);
            this.groupBox2.Controls.Add(this.chkName);
            this.groupBox2.Controls.Add(this.txtSandN);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtZipCode);
            this.groupBox2.Controls.Add(this.txtDoB);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.rdAdd);
            this.groupBox2.Controls.Add(this.rdNew);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索";
            // 
            // btnHistories
            // 
            this.btnHistories.Location = new System.Drawing.Point(310, 174);
            this.btnHistories.Name = "btnHistories";
            this.btnHistories.Size = new System.Drawing.Size(54, 23);
            this.btnHistories.TabIndex = 14;
            this.btnHistories.Text = "履歴";
            this.btnHistories.UseVisualStyleBackColor = true;
            this.btnHistories.Click += new System.EventHandler(this.btnHistories_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "検索条件クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearching
            // 
            this.btnSearching.Location = new System.Drawing.Point(106, 174);
            this.btnSearching.Name = "btnSearching";
            this.btnSearching.Size = new System.Drawing.Size(117, 23);
            this.btnSearching.TabIndex = 12;
            this.btnSearching.Text = "検索";
            this.btnSearching.UseVisualStyleBackColor = true;
            this.btnSearching.Click += new System.EventHandler(this.btnSearching_Click);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(13, 148);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(27, 13);
            this.lblSN.TabIndex = 16;
            this.lblSN.Text = "S/N";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "メールアドレス";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(13, 102);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(55, 13);
            this.lblZipcode.TabIndex = 14;
            this.lblZipcode.Text = "郵便番号";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(13, 79);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(55, 13);
            this.lblDoB.TabIndex = 13;
            this.lblDoB.Text = "生年月日";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "AND";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "名前";
            // 
            // chkSandN
            // 
            this.chkSandN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSandN.AutoSize = true;
            this.chkSandN.Location = new System.Drawing.Point(350, 147);
            this.chkSandN.Name = "chkSandN";
            this.chkSandN.Size = new System.Drawing.Size(15, 14);
            this.chkSandN.TabIndex = 11;
            this.chkSandN.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(350, 124);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(15, 14);
            this.chkEmail.TabIndex = 9;
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkZipCode
            // 
            this.chkZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkZipCode.AutoSize = true;
            this.chkZipCode.Location = new System.Drawing.Point(350, 101);
            this.chkZipCode.Name = "chkZipCode";
            this.chkZipCode.Size = new System.Drawing.Size(15, 14);
            this.chkZipCode.TabIndex = 7;
            this.chkZipCode.UseVisualStyleBackColor = true;
            // 
            // chkDoB
            // 
            this.chkDoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDoB.AutoSize = true;
            this.chkDoB.Location = new System.Drawing.Point(350, 78);
            this.chkDoB.Name = "chkDoB";
            this.chkDoB.Size = new System.Drawing.Size(15, 14);
            this.chkDoB.TabIndex = 5;
            this.chkDoB.UseVisualStyleBackColor = true;
            // 
            // chkName
            // 
            this.chkName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(350, 55);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(15, 14);
            this.chkName.TabIndex = 3;
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // txtSandN
            // 
            this.txtSandN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSandN.Location = new System.Drawing.Point(106, 144);
            this.txtSandN.Name = "txtSandN";
            this.txtSandN.Size = new System.Drawing.Size(235, 20);
            this.txtSandN.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(106, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZipCode.Location = new System.Drawing.Point(106, 98);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(235, 20);
            this.txtZipCode.TabIndex = 6;
            // 
            // txtDoB
            // 
            this.txtDoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoB.Location = new System.Drawing.Point(106, 75);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(235, 20);
            this.txtDoB.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(106, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 2;
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Location = new System.Drawing.Point(195, 19);
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
            this.rdNew.Location = new System.Drawing.Point(106, 19);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgResult.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgResult.Location = new System.Drawing.Point(3, 212);
            this.dtgResult.MultiSelect = false;
            this.dtgResult.Name = "dtgResult";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgResult.Size = new System.Drawing.Size(804, 292);
            this.dtgResult.TabIndex = 28;
            this.dtgResult.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgResult_ColumnHeaderMouseClick);
            this.dtgResult.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dtgResult_ColumnWidthChanged);
            this.dtgResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgResult_RowPostPaint);
            // 
            // colCheck
            // 
            this.colCheck.DataPropertyName = "IsChecked";
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCheck.Width = 52;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "USER ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "名前";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colName.Width = 120;
            // 
            // colDoB
            // 
            this.colDoB.DataPropertyName = "DoB";
            this.colDoB.HeaderText = "年月日";
            this.colDoB.Name = "colDoB";
            this.colDoB.ReadOnly = true;
            this.colDoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colPostNo
            // 
            this.colPostNo.DataPropertyName = "PostNo";
            this.colPostNo.HeaderText = "郵便番号";
            this.colPostNo.Name = "colPostNo";
            this.colPostNo.ReadOnly = true;
            this.colPostNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "メールアドレス ";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colSN
            // 
            this.colSN.DataPropertyName = "SN";
            this.colSN.HeaderText = "S/N";
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            this.colSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // colHeight
            // 
            this.colHeight.DataPropertyName = "Height";
            this.colHeight.HeaderText = "身長";
            this.colHeight.Name = "colHeight";
            this.colHeight.ReadOnly = true;
            this.colHeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colHeight.Visible = false;
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
            // colSaveDate
            // 
            this.colSaveDate.DataPropertyName = "SaveDate";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSaveDate.DefaultCellStyle = dataGridViewCellStyle10;
            this.colSaveDate.HeaderText = "年月日_SaveDate";
            this.colSaveDate.Name = "colSaveDate";
            this.colSaveDate.ReadOnly = true;
            this.colSaveDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSaveDate.Visible = false;
            this.colSaveDate.Width = 150;
            // 
            // lblRowTotal
            // 
            this.lblRowTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowTotal.AutoSize = true;
            this.lblRowTotal.Location = new System.Drawing.Point(8, 508);
            this.lblRowTotal.Name = "lblRowTotal";
            this.lblRowTotal.Size = new System.Drawing.Size(16, 13);
            this.lblRowTotal.TabIndex = 30;
            this.lblRowTotal.Text = "...";
            // 
            // ucPaging
            // 
            this.ucPaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPaging.Location = new System.Drawing.Point(473, 508);
            this.ucPaging.Name = "ucPaging";
            this.ucPaging.Size = new System.Drawing.Size(334, 28);
            this.ucPaging.TabIndex = 29;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearching;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkSandN;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkZipCode;
        private System.Windows.Forms.CheckBox chkDoB;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.TextBox txtSandN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.RadioButton rdNew;
        private System.Windows.Forms.DataGridView dtgResult;
        private System.Windows.Forms.Button bntBrower;
        private System.Windows.Forms.TextBox txtFolderOutPut;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblFolderOutput;
        private System.Windows.Forms.CheckBox chkSandNOut;
        private System.Windows.Forms.CheckBox chkEmailOut;
        private System.Windows.Forms.CheckBox chkZipCodeOut;
        private System.Windows.Forms.CheckBox chkDoBOut;
        private System.Windows.Forms.CheckBox chkNameOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label5;
        private UC.UCPaging ucPaging;
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
        private System.Windows.Forms.Label lblRowTotal;
    }
}
