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

    public partial class SearchReview : Form
    {
        private int prof_id;
        private readonly string prof_name;
        private ReviewsDataEF.DBReviewsEntities ctx_review = new DBReviewsEntities();

        public IQueryable<REVIEW> rEVIEWs;

        public SearchReview()
        {
            InitializeComponent();

        }

        public SearchReview(int id_prof, string name_prof)
        {
            InitializeComponent();
            prof_id = id_prof;
            prof_name = name_prof;

            ctx_review = new ReviewsDataEF.DBReviewsEntities();
            Text = String.Concat(Text, " ", prof_name);

            findReview();
        }

        private void findReview ()
        {
            var Rev = ctx_review.ChangeTracker.Entries<SearchReview>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (Rev.Count != 0) MessageBox.Show("Need to save changes!", "View review to professor!");
            else
            {
                ctx_review.Dispose();
                ctx_review = new ReviewsDataEF.DBReviewsEntities();

                var query = (from c in ctx_review.REVIEW
                             where c.ID_PROFESSOR == prof_id select c);
              
                query.Load();
                rEVIEWBindingSource.DataSource = ctx_review.REVIEW.Local.ToBindingList();
            }
        }

        private void SearchReview_Load(object sender, EventArgs e)
        {
            

            comboBoxProfessor.DataSource = ctx_review.PROFESSOR.ToList();
            comboBoxProfessor.SelectedItem = null;

            comboBoxRate.DataSource = ctx_review.RATE.ToList();
            comboBoxRate.SelectedItem = null;

            pROFESSORDataGridViewTextBoxColumn.DataSource = ctx_review.PROFESSOR.ToList();
            sTUDENTDataGridViewTextBoxColumn.DataSource = ctx_review.STUDENT.ToList();
            rATEDataGridViewTextBoxColumn.DataSource = ctx_review.RATE.ToList();
           
            
        }

        private void dataGridViewReview_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void rEVIEWBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxProfessor_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxProfessor.Enabled = Convert.ToBoolean(checkBoxProfessor.CheckState);
            comboBoxProfessor.SelectedItem = null;
        }

        private void checkBoxRate_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxRate.Enabled = Convert.ToBoolean(checkBoxRate.CheckState);
            comboBoxRate.SelectedItem = null;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            

            if (Convert.ToBoolean(checkBoxProfessor.CheckState) && Convert.ToBoolean(checkBoxRate.CheckState) )
            {
                int prof_id = (int)comboBoxProfessor.SelectedValue;
                int rate_id = (int)comboBoxRate.SelectedValue;

                var query = (from c in ctx_review.REVIEW
                             where (c.ID_PROFESSOR == prof_id && c.ID_RATE == rate_id)
                             select c);
                //var query1 = (from c in ctx_review.PROFESSOR
                //             where (c.ID_PROFESSOR == prof_id )
                //             select c.NAME_PROFESSOR);

                //query.Load();
                // rEVIEWBindingSource.DataSource = query;
                dataGridViewReview.DataSource = query.ToList();
               

                
              
               // dataGridViewReview.Refresh();
            }
            else if (!Convert.ToBoolean(checkBoxProfessor.CheckState) && Convert.ToBoolean(checkBoxRate.CheckState))
            {

                int rate_id = (int)comboBoxRate.SelectedValue;

                var query = (from c in ctx_review.REVIEW
                             where ( c.ID_RATE == rate_id)
                             select c);
                query.Load();
                // rEVIEWBindingSource.DataSource = ctx_review.REVIEW.Local.ToBindingList();
                dataGridViewReview.DataSource = query.ToList();
                dataGridViewReview.Refresh();
                //dataGridViewReview.DataSource = ctx_review.REVIEW.Local.ToBindingList();
             
            } else 
                if (Convert.ToBoolean(checkBoxProfessor.CheckState) && !Convert.ToBoolean(checkBoxRate.CheckState))
            {
                int prof_id = (int)comboBoxProfessor.SelectedValue;

                var query = (from c in ctx_review.REVIEW
                             where (c.ID_PROFESSOR == prof_id )
                             select c);
                query.Load();
                //rEVIEWBindingSource.DataSource = ctx_review.REVIEW.Local.ToBindingList();
                dataGridViewReview.DataSource = query.ToList();
                dataGridViewReview.Refresh();
                //  dataGridViewReview.DataSource = ctx_review.REVIEW.Local.ToBindingList();
                //dataGridViewReview.Refresh();
                //query
            }
           
        }

        private void dataGridViewReview_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnExportXml_Click(object sender, EventArgs e)
        {
             var obj = new ReviewsDataEF.DBReviewsEntities();
           
            rEVIEWs = (from c in obj.REVIEW select c);
           // int s = rEVIEWs.ToList().Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Review.xml";
            CreateXml.Create(rEVIEWs,  path );
            MessageBox.Show("Xml File Created!!!", "COMPLITLY!!!!!");
        }
    }
}
