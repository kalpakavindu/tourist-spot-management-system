using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tourist_spot_management_system.Panels
{
    public partial class AccountPanel : Form
    {
        private int user_id;
        private Database conn;

        public AccountPanel(int id)
        {
            InitializeComponent();
            conn = new Database();
            user_id = id;
            loadData();
        }

        private void loadData()
        {
            if(user_id != -1)
            {
                try
                {
                    string query = $"SELECT * FROM UsersTable WHERE id={user_id}";
                    DataTable res = conn.GetData(query);

                    input_fname.Text = (string)res.Rows[0]["first_name"];
                    input_lname.Text = (string)res.Rows[0]["last_name"];
                    input_email.Text = (string)res.Rows[0]["email"];

                    if (!res.Rows[0].IsNull("dob"))
                    { 
                        input_dob.Value = DateTime.ParseExact((string)res.Rows[0]["dob"], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }

                    if (!res.Rows[0].IsNull("contact"))
                    {
                        input_contact.Text = (string)res.Rows[0]["contact"];
                    }

                    if (!res.Rows[0].IsNull("gender"))
                    {
                        input_gender.SelectedItem = (string)res.Rows[0]["gender"];
                    }
                }catch(Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void toggle_password_Click(object sender, EventArgs e)
        {
            if (input_password.UseSystemPasswordChar == true)
            {
                input_password.UseSystemPasswordChar = false;
                toggle_password.Image = Properties.Resources.eye_slash;
            }
            else
            {
                input_password.UseSystemPasswordChar = true;
                toggle_password.Image = Properties.Resources.eye;
            }
        }

        private void toggle_cpassword_Click(object sender, EventArgs e)
        {
            if (input_cpassword.UseSystemPasswordChar == true)
            {
                input_cpassword.UseSystemPasswordChar = false;
                toggle_cpassword.Image = Properties.Resources.eye_slash;
            }
            else
            {
                input_cpassword.UseSystemPasswordChar = true;
                toggle_cpassword.Image = Properties.Resources.eye;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_fname.Text == "" || input_lname.Text == "" || input_email.Text == "") 
                {
                    throw new Exception("Fillout all required fields to continue.");
                }

                string query = $"UPDATE UsersTable SET first_name='{input_fname.Text}',last_name='{input_lname.Text}',email='{input_email.Text}',contact='{input_contact.Text}',dob='{input_dob.Value.Date.ToString("dd/MM/yyyy")}',gender='{input_gender.Text}' WHERE id={user_id}";
                conn.SetData(query);
                loadData();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK);
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            try
            {
                if(input_password.Text == "" || input_cpassword.Text == "")
                {
                    throw new Exception("Fillout required fields to continue.");
                }

                if(input_password.Text != input_cpassword.Text)
                {
                    throw new Exception("Passwords are not the same. Password confirmation failed.");
                }

                string query = $"UPDATE UsersTable SET password='{input_password.Text}' WHERE id={user_id}";
                conn.SetData(query);

                input_password.Text = "";
                input_cpassword.Text = "";
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
