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
    public partial class ViewReviewModal : Form
    {
        private Database conn;
        private int review_id;
        public int user_id;
        private bool approved = false;

        public ViewReviewModal(int id)
        {
            InitializeComponent();
            review_id = id;
            conn = new Database();
            loadData();
        }

        private void loadData()
        {
            try 
            {
                string query = $"SELECT message,rating,spot_id,user_id,status FROM ReviewsTable WHERE id={review_id}";
                DataTable res = conn.GetData(query);

                query = $"SELECT name FROM SpotsTable WHERE id={(int)res.Rows[0]["spot_id"]}";
                DataTable spotRes = conn.GetData(query);

                query = $"SELECT first_name,last_name FROM UsersTable WHERE id={(int)res.Rows[0]["user_id"]}";
                DataTable userRes = conn.GetData(query);

                user_id = (int)res.Rows[0]["user_id"];

                if ((int)res.Rows[0]["status"] == 0)
                {
                    btn_approve.Text = "Approve";
                    approved = false;
                }
                else
                {
                    btn_approve.Text = "Refuse";
                    approved = true;
                }

                label_spot.Text = (string)spotRes.Rows[0]["name"];
                label_rating.Text = (string)res.Rows[0]["rating"];
                label_review.Text = (string)res.Rows[0]["message"];
                label_username.Text = $"{(string)userRes.Rows[0]["first_name"]} {(string)userRes.Rows[0]["last_name"]}";
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"UPDATE ReviewsTable SET status=1 WHERE id={review_id}";
                if (approved)
                {
                    query = $"UPDATE ReviewsTable SET status=0 WHERE id={review_id}";
                }
                conn.SetData(query);
                this.Close();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM ReviewsTable WHERE id={review_id}";
                conn.SetData(query);
                this.Close();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
