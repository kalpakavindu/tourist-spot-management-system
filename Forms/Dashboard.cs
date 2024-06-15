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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DashboardPanel dashboardPanel = new DashboardPanel();
            dashboardPanel.TopLevel = false;
            mainPanel.Controls.Add(dashboardPanel);
            dashboardPanel.Show();
        }

        private void resetForm()
        {
            btn_dashboard.BackColor = Color.LightBlue;
            btn_spots.BackColor = Color.LightBlue;
            btn_reviews.BackColor = Color.LightBlue;
            btn_users.BackColor = Color.LightBlue;
            btn_logout.BackColor = Color.LightBlue;

            mainPanel.Controls.Clear();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            resetForm();
            btn_dashboard.BackColor = Color.Azure;

            DashboardPanel dashboardPanel = new DashboardPanel();
            dashboardPanel.TopLevel = false;
            mainPanel.Controls.Add(dashboardPanel);
            dashboardPanel.Show();
        }

        private void btn_spots_Click(object sender, EventArgs e)
        {
            resetForm();
            btn_spots.BackColor = Color.Azure;

            SpotsPanel spotsPanel = new SpotsPanel();
            spotsPanel.TopLevel = false;
            mainPanel.Controls.Add(spotsPanel);
            spotsPanel.Show();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            resetForm();
            btn_users.BackColor = Color.Azure;
            UsersPanel usersPanel = new UsersPanel();
            usersPanel.TopLevel = false;
            mainPanel.Controls.Add(usersPanel);
            usersPanel.Show();
        }

        private void btn_reviews_Click(object sender, EventArgs e)
        {
            resetForm();
            btn_reviews.BackColor = Color.Azure;
            ReviewsPanel reviewsPanel = new ReviewsPanel();
            reviewsPanel.TopLevel = false;
            mainPanel.Controls.Add(reviewsPanel);
            reviewsPanel.Show();
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
