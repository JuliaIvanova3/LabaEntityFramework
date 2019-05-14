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
using  ReviewsDataEF;

namespace ReviewsEF
{
    public partial class ReviewsData : Form
    {
        private ReviewsDataEF.DBReviewsEntities ctx;
    
        public ReviewsData()
        {
            InitializeComponent();
            ctx = new ReviewsDataEF.DBReviewsEntities();

            ctx.UNIVERSITY.Load();
            this.uNIVERSITYBindingSource.DataSource = ctx.UNIVERSITY.Local.ToBindingList();

            ctx.FACULTY.Load();
            this.fACULTYBindingSource.DataSource = ctx.FACULTY.Local.ToBindingList();

            ctx.PROFESSOR.Load();
            this.pROFESSORBindingSource.DataSource = ctx.PROFESSOR.Local.ToBindingList();

            ctx.RATE.Load();
            this.rATEBindingSource.DataSource = ctx.RATE.Local.ToBindingList();

            ctx.REVIEW.Load();
            this.rEVIEWBindingSource.DataSource = ctx.REVIEW.Local.ToBindingList();

            ctx.DEPARTMENT.Load();
            this.dEPARTMENTBindingSource.DataSource = ctx.DEPARTMENT.Local.ToBindingList();

            ctx.DISIPLINE.Load();
            this.dISIPLINEBindingSource.DataSource = ctx.DISIPLINE.Local.ToBindingList();

            ctx.DISIPLINE_DEPARTMENT.Load();
            this.dISIPLINEDEPARTMENTBindingSource.DataSource = ctx.DISIPLINE_DEPARTMENT.Local.ToBindingList();

            ctx.STUDENT.Load();
            this.sTUDENTBindingSource.DataSource = ctx.STUDENT.Local.ToBindingList();



        }

        private void ReviewsData_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveUniversity_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDeleteUniversity_Click(object sender, EventArgs e)
        {
            try
            {
                UNIVERSITY univ = (UNIVERSITY)dataGridViewUniversity.CurrentRow.DataBoundItem;
                var b = (from c in ctx.FACULTY where (c.ID_UNIVERSITY == univ.ID_UNIVERSITY) select c).Any();
                if (b)
                    MessageBox.Show("Can not deleted! To the university attached faculty!", "University removal error!");
                else
                {
                    uNIVERSITYBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error deleted info about university!", "Deleted info about university!");
                throw;
            }
        }

        private void btnSaveFaculty_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnDeleteFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                FACULTY facl = (FACULTY)dataGridViewFaculty.CurrentRow.DataBoundItem;
                var b = (from c in ctx.STUDENT where (c.ID_FACULTY == facl.ID_FACULTY) select c).Any();
                if (b)
                    MessageBox.Show("Can not deleted! To the faculty attached student!", "Faculty removal error!");
                else
                {
                    fACULTYBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error deleted info about faculty!", "Deleted info about faculty!");
                throw;
            }
        }
      
        private void bthSaveStudent_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void DataGridViewStudent_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnSaveDepart_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void dataGridViewDepartment_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnDeleteDepart_Click(object sender, EventArgs e)
        {
            try
            {
                DEPARTMENT depart = (DEPARTMENT)dataGridViewDepartment.CurrentRow.DataBoundItem;
                var b = (from c in ctx.DISIPLINE_DEPARTMENT where (depart.ID_DEPARTMENT == c.ID_DEPARTMENT) select c).Any();
                if (b)
                    MessageBox.Show("Can not deleted! To the department attached disipline!", "Department removal error!");
                else
                {
                    dEPARTMENTBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error deleted info about department!", "Deleted info about department!");
                throw;
            }
        }

        private void dataGridViewDisipDepart_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnDisipline_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDeleteDisipline_Click(object sender, EventArgs e)
        {
            dISIPLINEBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void btnSaveProfessor_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDeleteProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                PROFESSOR prof = (PROFESSOR)dataGridViewProfessor.CurrentRow.DataBoundItem;
                var b = (from c in ctx.REVIEW where (c.ID_PROFESSOR == prof.ID_PROFESSOR) select c).Any();
                if (b)
                    MessageBox.Show("Can not deleted! To the professor attached review!", "Professor removal error!");
                else
                {
                    pROFESSORBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error deleted info about Professor!", "Deleted info about Professor!");
            }
        }

        private void dataGridViewProfessor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnSaveRate_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDeleteRate_Click(object sender, EventArgs e)
        {
            try
            {
                RATE rate = (RATE)dataGridViewRate.CurrentRow.DataBoundItem;
                var b = (from c in ctx.REVIEW where (c.ID_RATE == rate.ID_RATE) select c).Any();
                if (b)
                    MessageBox.Show("Can not deleted! To the rate attached review!", "Rate removal error!");
                else
                {
                    rATEBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error deleted info about Rate!", "Deleted info about Rate!");
                throw;
            }
        }

        private void dataGridViewRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRate_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridViewReview_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnSaveReview_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            rEVIEWBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void dataGridViewProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pr = ctx.ChangeTracker.Entries<PROFESSOR>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (pr.Count != 0)
            {
                MessageBox.Show("", "");
            }
            else
            {
                try
                {
                    PROFESSOR prof = (PROFESSOR)dataGridViewProfessor.CurrentRow.DataBoundItem;
                    SearchReview schrev = new SearchReview(prof.ID_PROFESSOR, prof.NAME_PROFESSOR);
                    schrev.ShowDialog(this);
                    schrev.Dispose();
                }
                catch
                {
                    MessageBox.Show("Error", "!!!!!");
                }
            }
        }

        private void tabProfessor_Click(object sender, EventArgs e)
        {

        }
    }
}
