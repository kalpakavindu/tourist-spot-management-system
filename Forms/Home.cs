using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tourist_spot_management_system.Panels;

namespace tourist_spot_management_system.Forms
{
    public partial class Home : Form
    {
        private int user_id;

        public Home(int id)
        {
            InitializeComponent();
            user_id = id;
            ExplorePanel explorePanel = new ExplorePanel(user_id);
            explorePanel.TopLevel = false;
            mainPanel.Controls.Add(explorePanel);
            explorePanel.Show();
        }

        private void resetForm()
        {
            indicator_explore.BackColor = Color.Azure;
            indicator_profile.BackColor = Color.Azure;
            indicator_favourites.BackColor = Color.Azure;

            mainPanel.Controls.Clear();
        }

        private void btn_explore_Click(object sender, EventArgs e)
        {
            resetForm();
            indicator_explore.BackColor = Color.RoyalBlue;
            ExplorePanel explorePanel = new ExplorePanel(user_id);
            explorePanel.TopLevel = false;
            mainPanel.Controls.Add(explorePanel);
            explorePanel.Show();
        }

        private void btn_favourites_Click(object sender, EventArgs e)
        {
            resetForm();
            indicator_favourites.BackColor = Color.RoyalBlue;
            FavouritesPanel favouritesPanel = new FavouritesPanel(user_id);
            favouritesPanel.TopLevel = false;
            mainPanel.Controls.Add(favouritesPanel);
            favouritesPanel.Show();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            resetForm();
            indicator_profile.BackColor = Color.RoyalBlue;
            AccountPanel accountPanel = new AccountPanel(user_id);
            accountPanel.TopLevel = false;
            mainPanel.Controls.Add(accountPanel);
            accountPanel.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Auth authForm = new Auth();
            authForm.FormClosed += auth_FormClosed;
            authForm.Show();
            this.Hide();
        }

        private void auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
