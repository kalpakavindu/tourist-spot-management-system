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
    public partial class EditReviewModal : Form
    {
        private int user_id;
        private int spot_id;
        private int review_id;
        private Database conn;

        public EditReviewModal(int s_id, int u_id, int r_id)
        {
            InitializeComponent();
            user_id = u_id;
            spot_id = s_id;
            review_id = r_id;
            conn = new Database();
            loadData();
        }

        private void loadData()
        {
            try
            {
                if (review_id != -1)
                {
                    btn_delete.Visible = true;

                    string query = $"SELECT message,rating FROM ReviewsTable WHERE id={review_id}";
                    DataTable res = conn.GetData(query);
                    input_rating.Text = (string)res.Rows[0]["rating"];
                    input_review.Text = (string)res.Rows[0]["message"];
                }
                else
                {
                    btn_delete.Visible = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"INSERT INTO ReviewsTable (message,rating,spot_id,user_id) VALUES ('{input_review.Text}','{input_rating.Text}',{spot_id},{user_id})";

                if (review_id != -1)
                {
                    query = $"UPDATE ReviewsTable SET rating='{input_rating.Text}' message='{input_review.Text}'";
                }
                conn.SetData(query);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM ReviewsTable WHERE id={review_id}";
                conn.SetData(query);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}