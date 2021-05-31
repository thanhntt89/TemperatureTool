namespace TemperatureTool
{
    partial class SearchingHistories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchingHistories));
            this.dtgHistories = new System.Windows.Forms.DataGridView();
            this.colContents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChoise = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistories)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHistories
            // 
            this.dtgHistories.AllowUserToAddRows = false;
            this.dtgHistories.AllowUserToDeleteRows = false;
            this.dtgHistories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHistories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContents,
            this.colChoise,
            this.colId});
            this.dtgHistories.Location = new System.Drawing.Point(12, 12);
            this.dtgHistories.Name = "dtgHistories";
            this.dtgHistories.ReadOnly = true;
            this.dtgHistories.Size = new System.Drawing.Size(620, 479);
            this.dtgHistories.TabIndex = 0;
            this.dtgHistories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHistories_CellClick);
            this.dtgHistories.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgHistories_RowPostPaint);
            // 
            // colContents
            // 
            this.colContents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContents.DataPropertyName = "Contents";
            this.colContents.HeaderText = "検索条件";
            this.colContents.Name = "colContents";
            this.colContents.ReadOnly = true;
            this.colContents.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colContents.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colChoise
            // 
            this.colChoise.DataPropertyName = "Choise";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "選択";
            this.colChoise.DefaultCellStyle = dataGridViewCellStyle1;
            this.colChoise.HeaderText = "";
            this.colChoise.Name = "colChoise";
            this.colChoise.ReadOnly = true;
            this.colChoise.Width = 75;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // SearchingHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(644, 503);
            this.Controls.Add(this.dtgHistories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchingHistories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "検索履歴";
            this.Load += new System.EventHandler(this.SearchingHistories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHistories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContents;
        private System.Windows.Forms.DataGridViewButtonColumn colChoise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}