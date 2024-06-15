using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tourist_spot_management_system.Modals
{
    public partial class ViewSpotModal : Form
    {
        private Database conn;
        private int spot_id;
        private int user_id;
        private int fav_id = -1;

        public ViewSpotModal(int id,int u_id)
        {
            InitializeComponent();
            conn = new Database();
            spot_id = id;
            user_id = u_id;
            loadData();
        }

        private void loadData()
        {
            btn_favourite.Text = "Add to Favourites";
            fav_id = -1;
            try
            {
                string query = $"SELECT name,description,location FROM SpotsTable WHERE id={spot_id}";
                DataTable res = conn.GetData(query);

                query = $"SELECT id,message,rating,user_id FROM ReviewsTable WHERE spot_id={spot_id} AND status=1";
                DataTable reviewRes = conn.GetData(query);
                DataTable source = new DataTable();
                source.Columns.Add("id", typeof(int));
                source.Columns.Add("user_name", typeof(string));
                source.Columns.Add("rating", typeof(string));
                source.Columns.Add("review", typeof(string));

                foreach(DataRow r in reviewRes.Rows) 
                {
                    DataRow rs = source.NewRow();
                    string userQuery = $"SELECT first_name,last_name FROM UsersTable WHERE id={(int)r["user_id"]}";
                    DataTable userRes = conn.GetData(userQuery);
                    rs["user_name"] = $"{(string)userRes.Rows[0]["first_name"]} {(string)userRes.Rows[0]["last_name"]}";
                    rs["rating"] = (string)r["rating"];
                    rs["review"] = (string)r["message"];
                    rs["id"] = (int)r["id"];
                    source.Rows.Add(rs);
                }

                query = $"SELECT id,spot_id from FavouritesTable WHERE user_id={user_id}";
                DataTable favRes = conn.GetData(query);
                foreach(DataRow r in favRes.Rows)
                {
                    if(spot_id == (int)r["spot_id"])
                    {
                        btn_favourite.Text = "Remove from Favourites";
                        fav_id = (int)r["id"];
                    }
                }

                grid_reviews.DataSource = source;
                label_spot_name.Text = (string)res.Rows[0]["name"];
                label_spot_description.Text = (string)res.Rows[0]["description"];
                label_spot_location.Text = (string)res.Rows[0]["location"];
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_favourite_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"INSERT INTO FavouritesTable (spot_id,user_id) VALUES ({spot_id},{user_id})";

                if (fav_id != -1)
                {
                    query = $"DELETE FROM FavouritesTable WHERE id={fav_id}";
                }

                conn.SetData(query);
                loadData();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            EditReviewModal addReviewModal = new EditReviewModal(spot_id, user_id, -1);
            addReviewModal.FormClosed += addReviewModal_FormClosed;
            addReviewModal.ShowDialog();
        }

        private void addReviewModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void grid_reviews_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grid_reviews.Rows[e.RowIndex].Cells[0].Value);
            ViewReviewModal viewReviewModal = new ViewReviewModal(id);
            viewReviewModal.btn_approve.Visible = false;

            if (viewReviewModal.user_id == user_id)
            {
                viewReviewModal.btn_delete.Visible = true;
            }
            else
            {
                viewReviewModal.btn_delete.Visible = false;
            }

            viewReviewModal.ShowDialog();
        }
    }
}
