namespace tourist_spot_management_system.Modals
{
    partial class ViewReviewModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReviewModal));
            this.label_spot = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_rating = new System.Windows.Forms.Label();
            this.label_review = new System.Windows.Forms.Label();
            this.btn_approve = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_spot
            // 
            this.label_spot.AutoSize = true;
            this.label_spot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spot.Location = new System.Drawing.Point(12, 9);
            this.label_spot.Name = "label_spot";
            this.label_spot.Size = new System.Drawing.Size(126, 20);
            this.label_spot.TabIndex = 0;
            this.label_spot.Text = "Hortain Places";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tourist_spot_management_system.Properties.Resources.star_fill;
            this.pictureBox1.Location = new System.Drawing.Point(600, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rating.Location = new System.Drawing.Point(626, 9);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(27, 29);
            this.label_rating.TabIndex = 2;
            this.label_rating.Text = "5";
            // 
            // label_review
            // 
            this.label_review.Location = new System.Drawing.Point(16, 58);
            this.label_review.Name = "label_review";
            this.label_review.Size = new System.Drawing.Size(637, 298);
            this.label_review.TabIndex = 3;
            this.label_review.Text = resources.GetString("label_review.Text");
            // 
            // btn_approve
            // 
            this.btn_approve.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve.ForeColor = System.Drawing.Color.Azure;
            this.btn_approve.Location = new System.Drawing.Point(467, 398);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(90, 34);
            this.btn_approve.TabIndex = 4;
            this.btn_approve.Text = "Approve";
            this.btn_approve.UseVisualStyleBackColor = false;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.Azure;
            this.btn_delete.Location = new System.Drawing.Point(563, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 34);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(42, 405);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(114, 18);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "Kalpa Kavindu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tourist_spot_management_system.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(16, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // ViewReviewModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(665, 444);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.label_review);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_spot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(681, 483);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(681, 483);
            this.Name = "ViewReviewModal";
            this.Text = "ViewReview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_spot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.Label label_review;
        public System.Windows.Forms.Button btn_approve;
        public System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}