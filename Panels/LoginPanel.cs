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
    public partial class LoginPanel : Form
    {
        public int openOnClose = 0;
        public int loggedUserId = -1;
        private Database conn;

        public LoginPanel()
        {
            InitializeComponent();
            conn = new Database();
        }

        private void toggle_password_Click(object sender, EventArgs e)
        {
            if(input_password.UseSystemPasswordChar == true)
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

        private void btn_signin_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_email.Text == "" || input_password.Text == "")
                {
                    throw new Exception("Fillout all the fields to continue.");
                }

                if (input_email.Text == "admin")
                {
                    if (input_password.Text != "admin")
                    {
                        throw new Exception("Incorrect password.");
                    }
                    openOnClose = 1;
                    this.Close();
                    return;
                }

                string query = $"SELECT id,password FROM UsersTable WHERE email='{input_email.Text}'";
                DataTable res = conn.GetData(query);
                if(res.Rows.Count == 0)
                {
                    throw new Exception("Email address not registered. Consider Signing up.");
                }

                if ((string)res.Rows[0]["password"] != input_password.Text)
                {
                    throw new Exception("Incorrect password. Try again.");
                }

                loggedUserId = (int)res.Rows[0]["id"];
                this.Close();
            }catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
