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
    public partial class AddReview : Form
    {
        private ReviewsDataEF.DBReviewsEntities ctx;

        public AddReview()
        {
            InitializeComponent();
        }

        private void AddReview_Load(object sender, EventArgs e)
        {
            ctx = new DBReviewsEntities();
            comboBoxProfessor.DataSource = ctx.PROFESSOR.ToList();
            comboBoxProfessor.SelectedItem = null;

            comboBoxStudent.DataSource = ctx.STUDENT.ToList();
            comboBoxStudent.SelectedItem = null;

            comboBoxRate.DataSource = ctx.RATE.ToList();
            comboBoxRate.SelectedItem = null;
        }

        private void comboBoxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            REVIEW rEVIEW = new REVIEW();
            rEVIEW.ID_PROFESSOR = (int)comboBoxProfessor.SelectedValue;
            rEVIEW.ID_STUDENT = (int)comboBoxStudent.SelectedValue;
            rEVIEW.ID_RATE = (int)comboBoxRate.SelectedValue;
            rEVIEW.INFO_REVIEW = (string)textBoxInfo.Text;

            ctx.REVIEW.Add(rEVIEW);
            ctx.SaveChanges();

            this.Dispose();
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
