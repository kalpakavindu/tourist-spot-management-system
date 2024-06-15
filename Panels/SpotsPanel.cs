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
    public partial class SpotsPanel : Form
    {
        private Database conn;

        public SpotsPanel()
        {
            InitializeComponent();
            conn = new Database();
            loadData();
        }

        private void loadData()
        {
            try 
            {
                string query = "SELECT id,name,location,description FROM SpotsTable";
                DataTable res = conn.GetData(query);
                grid_spots.DataSource = res;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK);
            }
        }

        private void btn_add_spot_Click(object sender, EventArgs e)
        {
            EditSpotModal addSpotModal = new EditSpotModal(-1);
            addSpotModal.FormClosed += addSpotModal_FormClosed;
            addSpotModal.ShowDialog();
        }

        private void addSpotModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void grid_spots_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grid_spots.Rows[e.RowIndex].Cells[0].Value);
            EditSpotModal editSpotModal = new EditSpotModal(id);
            editSpotModal.FormClosed += addSpotModal_FormClosed;
            editSpotModal.ShowDialog();
        }
    }
}
