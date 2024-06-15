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
    public partial class FavouritesPanel : Form
    {
        private int user_id;
        private Database conn;

        public FavouritesPanel(int id)
        {
            InitializeComponent();
            user_id = id;
            conn = new Database();
            loadData();
        }

        private void loadData()
        {
            try
            {
                string query = $"SELECT spot_id FROM FavouritesTable WHERE user_id={user_id}";
                DataTable res = conn.GetData(query);
                DataTable source = new DataTable();
                source.Columns.Add("id", typeof(int));
                source.Columns.Add("name", typeof(string));
                source.Columns.Add("location", typeof(string));
                source.Columns.Add("description", typeof(string));

                foreach (DataRow r in res.Rows)
                {
                    string spotQuery = $"SELECT id,name,location,description FROM SpotsTable WHERE id={(int)r["spot_id"]}";
                    DataTable spotData = conn.GetData(spotQuery);
                    DataRow rs = source.NewRow();
                    rs["id"] = spotData.Rows[0]["id"];
                    rs["name"] = spotData.Rows[0]["name"];
                    rs["location"] = spotData.Rows[0]["location"];
                    rs["description"] = spotData.Rows[0]["description"];
                    source.Rows.Add(rs);
                }

                grid_places.DataSource = source;
            }catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK);
            }
        }

        private void grid_places_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grid_places.Rows[e.RowIndex].Cells[0].Value);
            ViewSpotModal viewSpotModal = new ViewSpotModal(id,user_id);
            viewSpotModal.FormClosed += viewSpotModal_FormClosed;
            viewSpotModal.ShowDialog();
        }

        private void viewSpotModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }
    }
}
