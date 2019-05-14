namespace ReviewsEF
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bthAddReview = new System.Windows.Forms.Button();
            this.bthEditDataBase = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bthXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bthAddReview
            // 
            this.bthAddReview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bthAddReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthAddReview.Location = new System.Drawing.Point(479, 353);
            this.bthAddReview.Name = "bthAddReview";
            this.bthAddReview.Size = new System.Drawing.Size(139, 48);
            this.bthAddReview.TabIndex = 0;
            this.bthAddReview.Text = "AddReview";
            this.bthAddReview.UseVisualStyleBackColor = false;
            this.bthAddReview.Click += new System.EventHandler(this.bthAddReview_Click);
            // 
            // bthEditDataBase
            // 
            this.bthEditDataBase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bthEditDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthEditDataBase.Location = new System.Drawing.Point(621, 408);
            this.bthEditDataBase.Name = "bthEditDataBase";
            this.bthEditDataBase.Size = new System.Drawing.Size(137, 44);
            this.bthEditDataBase.TabIndex = 1;
            this.bthEditDataBase.Text = "Edit DataBase";
            this.bthEditDataBase.UseVisualStyleBackColor = false;
            this.bthEditDataBase.Click += new System.EventHandler(this.bthEditDataBase_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(619, 353);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(139, 48);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(479, 408);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search Review";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bthXML
            // 
            this.bthXML.Location = new System.Drawing.Point(479, 458);
            this.bthXML.Name = "bthXML";
            this.bthXML.Size = new System.Drawing.Size(139, 42);
            this.bthXML.TabIndex = 4;
            this.bthXML.Text = "Export to Xml";
            this.bthXML.UseVisualStyleBackColor = true;
            this.bthXML.Click += new System.EventHandler(this.bthXML_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 576);
            this.Controls.Add(this.bthXML);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.bthEditDataBase);
            this.Controls.Add(this.bthAddReview);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bthAddReview;
        private System.Windows.Forms.Button bthEditDataBase;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button bthXML;
    }
}