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
    public partial class DashboardPanel : Form
    {
        private Database conn;

        public DashboardPanel()
        {
            InitializeComponent();
            conn = new Database();
            loadData();
        }

        private void loadData()
        {
            try
            {
                string query = "SELECT id FROM SpotsTable";
                DataTable spotCountRes = conn.GetData(query);

                query = "SELECT id FROM UsersTable";
                DataTable userCountRes = conn.GetData(query);

                query = "SELECT TOP(20) id,first_name,last_name,email,contact,dob FROM UsersTable ORDER BY id DESC";
                DataTable userRes = conn.GetData(query);

                query = "SELECT id,spot_id,user_id,rating,message FROM ReviewsTable WHERE status=0";
                DataTable res = conn.GetData(query);
                DataTable reviewSource = new DataTable();
                reviewSource.Columns.Add("id", typeof(int));
                reviewSource.Columns.Add("spot_name", typeof(string));
                reviewSource.Columns.Add("user_name", typeof(string));
                reviewSource.Columns.Add("rating", typeof(string));
                reviewSource.Columns.Add("review", typeof(string));

                foreach (DataRow r in res.Rows)
                {
                    string q = $"SELECT name FROM SpotsTable WHERE id={(int)r["spot_id"]}";
                    DataTable spotNameRes = conn.GetData(q);
                    q = $"SELECT first_name,last_name FROM UsersTable WHERE id={(int)r["user_id"]}";
                    DataTable userNameRes = conn.GetData(q);
                    DataRow dr = reviewSource.NewRow();
                    dr["id"] = (int)r["id"];
                    dr["spot_name"] = (string)spotNameRes.Rows[0]["name"];
                    dr["user_name"] = $"{(string)userNameRes.Rows[0]["first_name"]} {(string)userNameRes.Rows[0]["last_name"]}";
                    dr["rating"] = (string)r["rating"];
                    dr["review"] = (string)r["message"];
                    reviewSource.Rows.Add(dr);
                }

                grid_reviews.DataSource = reviewSource;
                grid_users.DataSource = userRes;
                count_spots.Text = spotCountRes.Rows.Count.ToString();
                count_users.Text = userCountRes.Rows.Count.ToString();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
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
