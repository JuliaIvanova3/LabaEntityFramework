namespace ReviewsEF
{
    partial class SearchReview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchReview));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.pROFESSORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxRate = new System.Windows.Forms.CheckBox();
            this.checkBoxProfessor = new System.Windows.Forms.CheckBox();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewReview = new System.Windows.Forms.DataGridView();
            this.pROFESSORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pROFESSORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sTUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNFOREVIEWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDREVIEWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPROFESSORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSTUDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESSORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESSORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.comboBoxRate);
            this.groupBox1.Controls.Add(this.comboBoxProfessor);
            this.groupBox1.Controls.Add(this.checkBoxRate);
            this.groupBox1.Controls.Add(this.checkBoxProfessor);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Options";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(426, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(115, 39);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.DisplayMember = "ID_RATE";
            this.comboBoxRate.Enabled = false;
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(158, 77);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRate.TabIndex = 3;
            this.comboBoxRate.ValueMember = "ID_RATE";
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.DataSource = this.pROFESSORBindingSource;
            this.comboBoxProfessor.DisplayMember = "NAME_PROFESSOR";
            this.comboBoxProfessor.Enabled = false;
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(158, 37);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProfessor.TabIndex = 2;
            this.comboBoxProfessor.ValueMember = "ID_PROFESSOR";
            // 
            // pROFESSORBindingSource
            // 
            this.pROFESSORBindingSource.DataSource = typeof(ReviewsDataEF.PROFESSOR);
            // 
            // checkBoxRate
            // 
            this.checkBoxRate.AutoSize = true;
            this.checkBoxRate.Location = new System.Drawing.Point(31, 77);
            this.checkBoxRate.Name = "checkBoxRate";
            this.checkBoxRate.Size = new System.Drawing.Size(60, 21);
            this.checkBoxRate.TabIndex = 1;
            this.checkBoxRate.Text = "Rate";
            this.checkBoxRate.UseVisualStyleBackColor = true;
            this.checkBoxRate.CheckedChanged += new System.EventHandler(this.checkBoxRate_CheckedChanged);
            // 
            // checkBoxProfessor
            // 
            this.checkBoxProfessor.AutoSize = true;
            this.checkBoxProfessor.Location = new System.Drawing.Point(31, 37);
            this.checkBoxProfessor.Name = "checkBoxProfessor";
            this.checkBoxProfessor.Size = new System.Drawing.Size(91, 21);
            this.checkBoxProfessor.TabIndex = 0;
            this.checkBoxProfessor.Text = "Professor";
            this.checkBoxProfessor.UseVisualStyleBackColor = true;
            this.checkBoxProfessor.CheckedChanged += new System.EventHandler(this.checkBoxProfessor_CheckedChanged);
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataSource = typeof(ReviewsDataEF.STUDENT);
            // 
            // dataGridViewReview
            // 
            this.dataGridViewReview.AllowUserToAddRows = false;
            this.dataGridViewReview.AutoGenerateColumns = false;
            this.dataGridViewReview.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROFESSORDataGridViewTextBoxColumn,
            this.sTUDENTDataGridViewTextBoxColumn,
            this.rATEDataGridViewTextBoxColumn,
            this.iNFOREVIEWDataGridViewTextBoxColumn,
            this.iDREVIEWDataGridViewTextBoxColumn,
            this.iDPROFESSORDataGridViewTextBoxColumn,
            this.iDSTUDENTDataGridViewTextBoxColumn,
            this.iDRATEDataGridViewTextBoxColumn});
            this.dataGridViewReview.DataSource = this.rEVIEWBindingSource;
            this.dataGridViewReview.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewReview.Name = "dataGridViewReview";
            this.dataGridViewReview.RowTemplate.Height = 24;
            this.dataGridViewReview.Size = new System.Drawing.Size(776, 251);
            this.dataGridViewReview.TabIndex = 1;
            this.dataGridViewReview.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewReview_DataError_1);
            // 
            // pROFESSORDataGridViewTextBoxColumn
            // 
            this.pROFESSORDataGridViewTextBoxColumn.DataPropertyName = "ID_PROFESSOR";
            this.pROFESSORDataGridViewTextBoxColumn.DataSource = this.pROFESSORBindingSource1;
            this.pROFESSORDataGridViewTextBoxColumn.DisplayMember = "NAME_PROFESSOR";
            this.pROFESSORDataGridViewTextBoxColumn.HeaderText = "PROFESSOR";
            this.pROFESSORDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pROFESSORDataGridViewTextBoxColumn.Name = "pROFESSORDataGridViewTextBoxColumn";
            this.pROFESSORDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pROFESSORDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pROFESSORDataGridViewTextBoxColumn.ValueMember = "ID_PROFESSOR";
            // 
            // pROFESSORBindingSource1
            // 
            this.pROFESSORBindingSource1.DataSource = typeof(ReviewsDataEF.PROFESSOR);
            // 
            // sTUDENTDataGridViewTextBoxColumn
            // 
            this.sTUDENTDataGridViewTextBoxColumn.DataPropertyName = "ID_STUDENT";
            this.sTUDENTDataGridViewTextBoxColumn.DataSource = this.sTUDENTBindingSource1;
            this.sTUDENTDataGridViewTextBoxColumn.DisplayMember = "NAME_STUDENT";
            this.sTUDENTDataGridViewTextBoxColumn.HeaderText = "STUDENT";
            this.sTUDENTDataGridViewTextBoxColumn.Name = "sTUDENTDataGridViewTextBoxColumn";
            this.sTUDENTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTUDENTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTUDENTDataGridViewTextBoxColumn.ValueMember = "ID_STUDENT";
            // 
            // sTUDENTBindingSource1
            // 
            this.sTUDENTBindingSource1.DataSource = typeof(ReviewsDataEF.STUDENT);
            // 
            // rATEDataGridViewTextBoxColumn
            // 
            this.rATEDataGridViewTextBoxColumn.DataPropertyName = "ID_RATE";
            this.rATEDataGridViewTextBoxColumn.DataSource = this.rATEBindingSource;
            this.rATEDataGridViewTextBoxColumn.DisplayMember = "MARKS_RATE";
            this.rATEDataGridViewTextBoxColumn.HeaderText = "RATE";
            this.rATEDataGridViewTextBoxColumn.Name = "rATEDataGridViewTextBoxColumn";
            this.rATEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rATEDataGridViewTextBoxColumn.ValueMember = "ID_RATE";
            // 
            // rATEBindingSource
            // 
            this.rATEBindingSource.DataSource = typeof(ReviewsDataEF.RATE);
            // 
            // iNFOREVIEWDataGridViewTextBoxColumn
            // 
            this.iNFOREVIEWDataGridViewTextBoxColumn.DataPropertyName = "INFO_REVIEW";
            this.iNFOREVIEWDataGridViewTextBoxColumn.HeaderText = "INFO_REVIEW";
            this.iNFOREVIEWDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iNFOREVIEWDataGridViewTextBoxColumn.Name = "iNFOREVIEWDataGridViewTextBoxColumn";
            // 
            // iDREVIEWDataGridViewTextBoxColumn
            // 
            this.iDREVIEWDataGridViewTextBoxColumn.DataPropertyName = "ID_REVIEW";
            this.iDREVIEWDataGridViewTextBoxColumn.HeaderText = "ID_REVIEW";
            this.iDREVIEWDataGridViewTextBoxColumn.Name = "iDREVIEWDataGridViewTextBoxColumn";
            this.iDREVIEWDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPROFESSORDataGridViewTextBoxColumn
            // 
            this.iDPROFESSORDataGridViewTextBoxColumn.DataPropertyName = "ID_PROFESSOR";
            this.iDPROFESSORDataGridViewTextBoxColumn.HeaderText = "ID_PROFESSOR";
            this.iDPROFESSORDataGridViewTextBoxColumn.Name = "iDPROFESSORDataGridViewTextBoxColumn";
            this.iDPROFESSORDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSTUDENTDataGridViewTextBoxColumn
            // 
            this.iDSTUDENTDataGridViewTextBoxColumn.DataPropertyName = "ID_STUDENT";
            this.iDSTUDENTDataGridViewTextBoxColumn.HeaderText = "ID_STUDENT";
            this.iDSTUDENTDataGridViewTextBoxColumn.Name = "iDSTUDENTDataGridViewTextBoxColumn";
            this.iDSTUDENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDRATEDataGridViewTextBoxColumn
            // 
            this.iDRATEDataGridViewTextBoxColumn.DataPropertyName = "ID_RATE";
            this.iDRATEDataGridViewTextBoxColumn.HeaderText = "ID_RATE";
            this.iDRATEDataGridViewTextBoxColumn.Name = "iDRATEDataGridViewTextBoxColumn";
            this.iDRATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // rEVIEWBindingSource
            // 
            this.rEVIEWBindingSource.DataSource = typeof(ReviewsDataEF.REVIEW);
            // 
            // SearchReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReview);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchReview";
            this.Text = "SearchReview";
            this.Load += new System.EventHandler(this.SearchReview_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESSORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESSORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.CheckBox checkBoxRate;
        private System.Windows.Forms.CheckBox checkBoxProfessor;
        private System.Windows.Forms.BindingSource pROFESSORBindingSource;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewReview;
        private System.Windows.Forms.BindingSource rEVIEWBindingSource;
        private System.Windows.Forms.BindingSource pROFESSORBindingSource1;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource1;
        private System.Windows.Forms.BindingSource rATEBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn pROFESSORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTUDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFOREVIEWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREVIEWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROFESSORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSTUDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRATEDataGridViewTextBoxColumn;
    }
}