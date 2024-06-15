using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tourist_spot_management_system.Panels
{
    public partial class RegisterPanel : Form
    {
        private Database conn;

        public RegisterPanel()
        {
            InitializeComponent();
            conn = new Database();
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

        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_fname.Text == "" || input_lname.Text == "" || input_email.Text == "" || input_password.Text == "" || input_cpassword.Text == "")
                {
                    throw new Exception("Fillout all the fields to continue.");
                }
                
                if (input_password.Text != input_cpassword.Text)
                {
                    throw new Exception("Passwords are not the same. Password confirmation failed.");
                }

                string query = $"INSERT INTO UsersTable (first_name, last_name, email, password) VALUES ('{input_fname.Text}','{input_lname.Text}','{input_email.Text}','{input_password.Text}')";
                conn.SetData(query);
                this.Close();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
