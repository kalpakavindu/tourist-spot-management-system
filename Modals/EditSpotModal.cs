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
    public partial class EditSpotModal : Form
    {
        public int spot_id;
        private Database conn;

        public EditSpotModal(int id = -1)
        {
            InitializeComponent();
            spot_id = id;
            conn = new Database();

            if(spot_id < 0)
            {
                btn_delete.Visible = false;
                this.Text = "Add new Tourist Spot";
            }
            else
            {
                loadData();
                btn_delete.Visible = true;
                this.Text = "Tourist Spot Details";
            }
        }

        private void loadData()
        {
            string query = $"SELECT name,description,location FROM SpotsTable WHERE id={spot_id}";
            DataTable res = conn.GetData(query);

            input_name.Text = (string)res.Rows[0]["name"];
            input_description.Text = (string)res.Rows[0]["description"];
            input_location.Text = (string)res.Rows[0]["location"];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try 
            {
                if(input_name.Text == "" || input_location.Text == "" || input_description.Text == "")
                {
                    throw new Exception("Fillout required fileds to continue.");
                }

                string query = $"INSERT INTO SpotsTable (name,description,location) VALUES ('{input_name.Text}','{input_description.Text}','{input_location.Text}')";

                if(spot_id != -1)
                {
                    query =$"UPDATE SpotsTable SET name='{input_name.Text}',description='{input_description.Text}',location='{input_location.Text}' WHERE id={spot_id}";
                }

                conn.SetData(query);
                this.Close();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM ReviewsTable WHERE spot_id={spot_id}";
                conn.SetData(query);
                query = $"DELETE FROM FavouritesTable WHERE spot_id={spot_id}";
                conn.SetData(query);
                query = $"DELETE FROM SpotsTable WHERE id={spot_id}";
                conn.SetData(query);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK);
            }
        }
    }
}
