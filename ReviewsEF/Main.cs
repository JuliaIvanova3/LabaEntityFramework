using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReviewsDataEF;

namespace ReviewsEF
{
    public partial class Main : Form
    {
        public IQueryable<REVIEW> rEVIEWs;

        public Main()
        {
            InitializeComponent();
        }

        private void bthEditDataBase_Click(object sender, EventArgs e)
        {
            ReviewsData form = new ReviewsData();
            form.Show();
        }

        private void bthAddReview_Click(object sender, EventArgs e)
        {
            AddReview form = new AddReview();
            form.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn form = new LogIn();
            form.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchReview form = new SearchReview();
            form.Show();
        }

        private void bthXML_Click(object sender, EventArgs e)
        {
            var obj = new ReviewsDataEF.DBReviewsEntities();

            rEVIEWs = (from c in obj.REVIEW select c);
            // int s = rEVIEWs.ToList().Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Review.xml";
            CreateXml.Create(rEVIEWs, path);
            MessageBox.Show("Xml File Created!!!", "COMPLITLY!!!!!");
        }
    }
}
