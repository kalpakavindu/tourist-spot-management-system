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
    public partial class ExplorePanel : Form
    {
        private Database conn;
        private int user_id;

        public ExplorePanel(int u_id)
        {
            InitializeComponent();
            conn = new Database();
            loadData();
            user_id = u_id;
        }

        private void loadData(string sq = "")
        {
            try
            {
                string query = "SELECT id,name,location,description FROM SpotsTable";
                
                if(sq != "")
                {
                    query = $"SELECT id,name,location,description FROM SpotsTable WHERE name LIKE '%{sq}%'";
                }

                DataTable res = conn.GetData(query);
                grid_results.DataSource = res;
            }catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchQuery = input_search.Text;
            loadData(searchQuery);
        }

        private void grid_results_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grid_results.Rows[e.RowIndex].Cells[0].Value);
            ViewSpotModal viewSpotModal = new ViewSpotModal(id, user_id);
            viewSpotModal.FormClosed += viewSpotModal_FormClosed;
            viewSpotModal.ShowDialog();
        }

        private void viewSpotModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }
    }
}
