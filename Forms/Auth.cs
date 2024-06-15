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
    public partial class Auth : Form
    {
        private LoginPanel loginPanel = new LoginPanel();
        private RegisterPanel registerPanel = new RegisterPanel();

        public Auth()
        {
            InitializeComponent();
            loginPanel.TopLevel = false;
            loginPanel.FormClosed += loginPanel_FormClosed;
            registerPanel.TopLevel = false;
            registerPanel.FormClosed += registerPanel_FormClosed;

            mainPanel.Controls.Add(loginPanel);
            loginPanel.Show();
        }

        private void loginPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (loginPanel.openOnClose)
            {
                case 1:
                    Dashboard dashboard = new Dashboard();
                    dashboard.FormClosed += closeApp;
                    dashboard.Show();
                    this.Hide();
                    break;
                default:
                    Home home = new Home(loginPanel.loggedUserId);
                    home.FormClosed += closeApp;
                    home.Show();
                    this.Hide();
                    break;
            }
        }

        private void registerPanel_FormClosed(object sender,FormClosedEventArgs e)
        {
            mainPanel.Controls.Add(loginPanel);
            loginPanel.Show();

            togglePanel.Text = "Sign up";
            panelMsg.Text = "Don't have and account?";
        }

        private void closeApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void togglePanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Clear();

            if (togglePanel.Text == "Sign up")
            {
                mainPanel.Controls.Add(registerPanel);
                registerPanel.Show();

                togglePanel.Text = "Sign in";
                panelMsg.Text = "Already have and account?";
            }
            else
            {
                mainPanel.Controls.Add(loginPanel);
                loginPanel.Show();

                togglePanel.Text = "Sign up";
                panelMsg.Text = "Don't have and account?";
            }
        }
    }
}
