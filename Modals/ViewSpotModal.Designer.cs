namespace tourist_spot_management_system.Modals
{
    partial class ViewSpotModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSpotModal));
            this.label_spot_name = new System.Windows.Forms.Label();
            this.label_spot_description = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_spot_location = new System.Windows.Forms.Label();
            this.grid_reviews = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_favourite = new System.Windows.Forms.Button();
            this.btn_review = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reviews)).BeginInit();
            this.SuspendLayout();
            // 
            // label_spot_name
            // 
            this.label_spot_name.AutoSize = true;
            this.label_spot_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spot_name.Location = new System.Drawing.Point(12, 9);
            this.label_spot_name.Name = "label_spot_name";
            this.label_spot_name.Size = new System.Drawing.Size(205, 31);
            this.label_spot_name.TabIndex = 0;
            this.label_spot_name.Text = "Hortain Places";
            // 
            // label_spot_description
            // 
            this.label_spot_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_spot_description.BackColor = System.Drawing.Color.Azure;
            this.label_spot_description.Location = new System.Drawing.Point(15, 49);
            this.label_spot_description.Name = "label_spot_description";
            this.label_spot_description.Size = new System.Drawing.Size(463, 309);
            this.label_spot_description.TabIndex = 1;
            this.label_spot_description.Text = resources.GetString("label_spot_description.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::tourist_spot_management_system.Properties.Resources.map_pin;
            this.pictureBox1.Location = new System.Drawing.Point(18, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_spot_location
            // 
            this.label_spot_location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_spot_location.AutoSize = true;
            this.label_spot_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spot_location.Location = new System.Drawing.Point(54, 377);
            this.label_spot_location.Name = "label_spot_location";
            this.label_spot_location.Size = new System.Drawing.Size(175, 20);
            this.label_spot_location.TabIndex = 3;
            this.label_spot_location.Text = "Nuwara Eliya, Sri Lanka";
            // 
            // grid_reviews
            // 
            this.grid_reviews.AllowUserToAddRows = false;
            this.grid_reviews.AllowUserToDeleteRows = false;
            this.grid_reviews.AllowUserToResizeRows = false;
            this.grid_reviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_reviews.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_reviews.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grid_reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reviews.GridColor = System.Drawing.Color.Azure;
            this.grid_reviews.Location = new System.Drawing.Point(484, 28);
            this.grid_reviews.MultiSelect = false;
            this.grid_reviews.Name = "grid_reviews";
            this.grid_reviews.ReadOnly = true;
            this.grid_reviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_reviews.Size = new System.Drawing.Size(450, 437);
            this.grid_reviews.TabIndex = 4;
            this.grid_reviews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_reviews_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reviews";
            // 
            // btn_favourite
            // 
            this.btn_favourite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_favourite.BackColor = System.Drawing.Color.Orange;
            this.btn_favourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_favourite.ForeColor = System.Drawing.Color.Azure;
            this.btn_favourite.Location = new System.Drawing.Point(18, 432);
            this.btn_favourite.Name = "btn_favourite";
            this.btn_favourite.Size = new System.Drawing.Size(180, 33);
            this.btn_favourite.TabIndex = 6;
            this.btn_favourite.Text = "Add to Favourites";
            this.btn_favourite.UseVisualStyleBackColor = false;
            this.btn_favourite.Click += new System.EventHandler(this.btn_favourite_Click);
            // 
            // btn_review
            // 
            this.btn_review.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_review.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_review.ForeColor = System.Drawing.Color.Azure;
            this.btn_review.Location = new System.Drawing.Point(204, 432);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(134, 33);
            this.btn_review.TabIndex = 7;
            this.btn_review.Text = "Write a Review";
            this.btn_review.UseVisualStyleBackColor = false;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // ViewSpotModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(946, 477);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.btn_favourite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_reviews);
            this.Controls.Add(this.label_spot_location);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_spot_description);
            this.Controls.Add(this.label_spot_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(962, 516);
            this.Name = "ViewSpotModal";
            this.Text = "Tourist Spot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_spot_name;
        private System.Windows.Forms.Label label_spot_description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_spot_location;
        private System.Windows.Forms.DataGridView grid_reviews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_favourite;
        private System.Windows.Forms.Button btn_review;
    }
}