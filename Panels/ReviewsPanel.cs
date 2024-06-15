using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tourist_spot_management_system.Modals;

namespace tourist_spot_management_system.Panels
{
    public partial class ReviewsPanel : Form
    {
        private Database conn;

        public ReviewsPanel()
        {
            InitializeComponent();
            conn = new Database();
            loadData();
        }

        private void loadData()
        {
            try
            {
                string query = "SELECT id,spot_id,user_id,status,message,rating FROM ReviewsTable";
                DataTable res = conn.GetData(query);

                DataTable source = new DataTable();
                source.Columns.Add("id", typeof(int));
                source.Columns.Add("spot_name", typeof(string));
                source.Columns.Add("user_name", typeof(string));
                source.Columns.Add("rating", typeof(string));
                source.Columns.Add("review", typeof(string));

                foreach (DataRow r in res.Rows)
                {
                    DataTable userData = conn.GetData($"SELECT first_name,last_name FROM UsersTable WHERE id={(int)r["user_id"]}");
                    DataTable spotData = conn.GetData($"SELECT name FROM SpotsTable WHERE id={(int)r["spot_id"]}");

                    DataRow rs = source.NewRow();
                    rs["id"] = (int)r["id"];
                    rs["spot_name"] = (string)spotData.Rows[0]["name"];
                    rs["user_name"] = $"{(string)userData.Rows[0]["first_name"]} {(string)userData.Rows[0]["last_name"]}";
                    rs["rating"] = (string)r["rating"];
                    rs["review"] = (string)r["message"];

                    source.Rows.Add(rs);
                }

                grid_reviews.DataSource = source;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK);
            }
        }

        private void grid_reviews_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grid_reviews.Rows[e.RowIndex].Cells[0].Value);
            ViewReviewModal viewReviewModal = new ViewReviewModal(id);
            viewReviewModal.FormClosed += viewReviewModal_FormClosed;
            viewReviewModal.ShowDialog();
        }

        private void viewReviewModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }
    }
}
