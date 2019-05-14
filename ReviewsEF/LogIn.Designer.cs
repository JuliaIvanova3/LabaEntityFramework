namespace ReviewsEF
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.fACULTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bthLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fACULTYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faculty";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.DataSource = this.fACULTYBindingSource;
            this.comboBoxFaculty.DisplayMember = "NAME_FACULTY";
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(140, 102);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(151, 24);
            this.comboBoxFaculty.TabIndex = 3;
            this.comboBoxFaculty.ValueMember = "ID_FACULTY";
            // 
            // fACULTYBindingSource
            // 
            this.fACULTYBindingSource.DataSource = typeof(ReviewsDataEF.FACULTY);
            // 
            // bthLogIn
            // 
            this.bthLogIn.Location = new System.Drawing.Point(140, 169);
            this.bthLogIn.Name = "bthLogIn";
            this.bthLogIn.Size = new System.Drawing.Size(151, 31);
            this.bthLogIn.TabIndex = 4;
            this.bthLogIn.Text = "LogIn";
            this.bthLogIn.UseVisualStyleBackColor = true;
            this.bthLogIn.Click += new System.EventHandler(this.bthLogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(367, 234);
            this.Controls.Add(this.bthLogIn);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fACULTYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.BindingSource fACULTYBindingSource;
        private System.Windows.Forms.Button bthLogIn;
    }
}