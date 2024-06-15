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
    public partial class UsersPanel : Form
    {
        private Database conn;

        public UsersPanel()
        {
            InitializeComponent();
            conn = new Database();
            loadData();
        }

        private void loadData()
        {
            try
            {
                string query = "SELECT id,first_name,last_name,email,gender,dob FROM UsersTable";
                DataTable res = conn.GetData(query);
                grid_users.DataSource = res;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
