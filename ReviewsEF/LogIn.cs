using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ReviewsDataEF;

namespace ReviewsEF
{
    public partial class LogIn : Form
    {
        private ReviewsDataEF.DBReviewsEntities ctx;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            ctx = new DBReviewsEntities();

            comboBoxFaculty.DataSource = ctx.FACULTY.ToList();
            comboBoxFaculty.SelectedItem = null;
        }

        private void bthLogIn_Click(object sender, EventArgs e)
        {
            STUDENT std = new STUDENT();
            std.NAME_STUDENT = (string)textBox1.Text;
            std.ID_FACULTY = (int)comboBoxFaculty.SelectedValue;

            ctx.STUDENT.Add(std);
            ctx.SaveChanges();

            this.Dispose();
        }
    }
}
