namespace ReviewsEF
{
    partial class AddReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReview));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.pROFESSORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.rATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.btnAddReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESSORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rATEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor";
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pROFESSORBindingSource, "ID_PROFESSOR", true));
            this.comboBoxProfessor.DataSource = this.pROFESSORBindingSource;
            this.comboBoxProfessor.DisplayMember = "NAME_PROFESSOR";
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(127, 35);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProfessor.TabIndex = 1;
            this.comboBoxProfessor.ValueMember = "ID_PROFESSOR";
            this.comboBoxProfessor.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfessor_SelectedIndexChanged);
            // 
            // pROFESSORBindingSource
            // 
            this.pROFESSORBindingSource.DataSource = typeof(ReviewsDataEF.PROFESSOR);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.DataSource = this.sTUDENTBindingSource;
            this.comboBoxStudent.DisplayMember = "NAME_STUDENT";
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(127, 72);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudent.TabIndex = 3;
            this.comboBoxStudent.ValueMember = "ID_STUDENT";
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataSource = typeof(ReviewsDataEF.STUDENT);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate";
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.DataSource = this.rATEBindingSource;
            this.comboBoxRate.DisplayMember = "MARKS_RATE";
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(127, 103);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRate.TabIndex = 5;
            this.comboBoxRate.ValueMember = "ID_RATE";
            // 
            // rATEBindingSource
            // 
            this.rATEBindingSource.DataSource = typeof(ReviewsDataEF.RATE);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Review";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(127, 148);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(121, 22);
            this.textBoxInfo.TabIndex = 7;
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(127, 207);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(121, 28);
            this.btnAddReview.TabIndex = 8;
            this.btnAddReview.Text = "ADD";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 287);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProfessor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddReview";
            this.Text = "AddReview";
            this.Load += new System.EventHandler(this.AddReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROFESSORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rATEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.BindingSource pROFESSORBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.BindingSource rATEBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button btnAddReview;
    }
}