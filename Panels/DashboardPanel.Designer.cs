namespace tourist_spot_management_system.Panels
{
    partial class DashboardPanel
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grid_users = new System.Windows.Forms.DataGridView();
            this.grid_reviews = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.count_users = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.count_spots = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reviews)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Recently registered users";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Reviews to be approved";
            // 
            // grid_users
            // 
            this.grid_users.AllowUserToAddRows = false;
            this.grid_users.AllowUserToDeleteRows = false;
            this.grid_users.AllowUserToResizeRows = false;
            this.grid_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_users.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_users.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grid_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users.GridColor = System.Drawing.Color.Azure;
            this.grid_users.Location = new System.Drawing.Point(300, 140);
            this.grid_users.MultiSelect = false;
            this.grid_users.Name = "grid_users";
            this.grid_users.ReadOnly = true;
            this.grid_users.Size = new System.Drawing.Size(260, 296);
            this.grid_users.TabIndex = 4;
            // 
            // grid_reviews
            // 
            this.grid_reviews.AllowUserToAddRows = false;
            this.grid_reviews.AllowUserToDeleteRows = false;
            this.grid_reviews.AllowUserToResizeRows = false;
            this.grid_reviews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_reviews.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_reviews.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grid_reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reviews.GridColor = System.Drawing.Color.Azure;
            this.grid_reviews.Location = new System.Drawing.Point(15, 121);
            this.grid_reviews.MultiSelect = false;
            this.grid_reviews.Name = "grid_reviews";
            this.grid_reviews.ReadOnly = true;
            this.grid_reviews.Size = new System.Drawing.Size(276, 315);
            this.grid_reviews.TabIndex = 4;
            this.grid_reviews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_reviews_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Moccasin;
            this.panel3.Controls.Add(this.count_users);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(419, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 89);
            this.panel3.TabIndex = 11;
            // 
            // count_users
            // 
            this.count_users.AutoSize = true;
            this.count_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_users.Location = new System.Drawing.Point(60, 45);
            this.count_users.Name = "count_users";
            this.count_users.Size = new System.Drawing.Size(74, 37);
            this.count_users.TabIndex = 1;
            this.count_users.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Users";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.count_spots);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(256, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 89);
            this.panel2.TabIndex = 10;
            // 
            // count_spots
            // 
            this.count_spots.AutoSize = true;
            this.count_spots.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_spots.Location = new System.Drawing.Point(60, 45);
            this.count_spots.Name = "count_spots";
            this.count_spots.Size = new System.Drawing.Size(74, 37);
            this.count_spots.TabIndex = 1;
            this.count_spots.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Spots";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(10, 30);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(151, 25);
            this.user_name.TabIndex = 9;
            this.user_name.Text = "Administrator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome back,";
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grid_users);
            this.Controls.Add(this.grid_reviews);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(570, 450);
            this.Name = "DashboardPanel";
            this.Text = "DashboardPanel";
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reviews)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grid_users;
        private System.Windows.Forms.DataGridView grid_reviews;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label count_users;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label count_spots;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label2;
    }
}