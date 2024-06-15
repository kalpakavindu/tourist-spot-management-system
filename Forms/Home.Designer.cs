namespace tourist_spot_management_system.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_explore = new System.Windows.Forms.PictureBox();
            this.btn_favourites = new System.Windows.Forms.PictureBox();
            this.btn_profile = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.PictureBox();
            this.indicator_profile = new System.Windows.Forms.Panel();
            this.indicator_favourites = new System.Windows.Forms.Panel();
            this.indicator_explore = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_explore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_favourites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_profile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tourist Spot Management System";
            // 
            // btn_explore
            // 
            this.btn_explore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_explore.Image = global::tourist_spot_management_system.Properties.Resources.compass;
            this.btn_explore.InitialImage = global::tourist_spot_management_system.Properties.Resources.compass;
            this.btn_explore.Location = new System.Drawing.Point(0, 0);
            this.btn_explore.Name = "btn_explore";
            this.btn_explore.Size = new System.Drawing.Size(43, 41);
            this.btn_explore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_explore.TabIndex = 2;
            this.btn_explore.TabStop = false;
            this.btn_explore.Click += new System.EventHandler(this.btn_explore_Click);
            // 
            // btn_favourites
            // 
            this.btn_favourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_favourites.Image = global::tourist_spot_management_system.Properties.Resources.star;
            this.btn_favourites.InitialImage = global::tourist_spot_management_system.Properties.Resources.compass;
            this.btn_favourites.Location = new System.Drawing.Point(59, 0);
            this.btn_favourites.Name = "btn_favourites";
            this.btn_favourites.Size = new System.Drawing.Size(43, 41);
            this.btn_favourites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_favourites.TabIndex = 3;
            this.btn_favourites.TabStop = false;
            this.btn_favourites.Click += new System.EventHandler(this.btn_favourites_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.Image = global::tourist_spot_management_system.Properties.Resources.person;
            this.btn_profile.InitialImage = global::tourist_spot_management_system.Properties.Resources.compass;
            this.btn_profile.Location = new System.Drawing.Point(118, 0);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(43, 41);
            this.btn_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_profile.TabIndex = 4;
            this.btn_profile.TabStop = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.indicator_profile);
            this.panel1.Controls.Add(this.indicator_favourites);
            this.panel1.Controls.Add(this.indicator_explore);
            this.panel1.Controls.Add(this.btn_explore);
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Controls.Add(this.btn_favourites);
            this.panel1.Location = new System.Drawing.Point(601, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 51);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(178, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 5);
            this.panel2.TabIndex = 10;
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Image = global::tourist_spot_management_system.Properties.Resources.arrow_right_from_line;
            this.btn_logout.InitialImage = global::tourist_spot_management_system.Properties.Resources.compass;
            this.btn_logout.Location = new System.Drawing.Point(178, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(43, 41);
            this.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logout.TabIndex = 9;
            this.btn_logout.TabStop = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // indicator_profile
            // 
            this.indicator_profile.Location = new System.Drawing.Point(118, 41);
            this.indicator_profile.Name = "indicator_profile";
            this.indicator_profile.Size = new System.Drawing.Size(43, 5);
            this.indicator_profile.TabIndex = 8;
            // 
            // indicator_favourites
            // 
            this.indicator_favourites.Location = new System.Drawing.Point(59, 41);
            this.indicator_favourites.Name = "indicator_favourites";
            this.indicator_favourites.Size = new System.Drawing.Size(43, 5);
            this.indicator_favourites.TabIndex = 7;
            // 
            // indicator_explore
            // 
            this.indicator_explore.BackColor = System.Drawing.Color.RoyalBlue;
            this.indicator_explore.Location = new System.Drawing.Point(0, 41);
            this.indicator_explore.Name = "indicator_explore";
            this.indicator_explore.Size = new System.Drawing.Size(43, 5);
            this.indicator_explore.TabIndex = 6;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.Azure;
            this.mainPanel.Location = new System.Drawing.Point(0, 69);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(834, 392);
            this.mainPanel.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Home";
            this.Text = "Tourist Spot Management System";
            ((System.ComponentModel.ISupportInitialize)(this.btn_explore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_favourites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_profile)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_explore;
        private System.Windows.Forms.PictureBox btn_favourites;
        private System.Windows.Forms.PictureBox btn_profile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel indicator_profile;
        private System.Windows.Forms.Panel indicator_favourites;
        private System.Windows.Forms.Panel indicator_explore;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_logout;
    }
}