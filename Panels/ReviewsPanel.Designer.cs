namespace tourist_spot_management_system.Panels
{
    partial class ReviewsPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.grid_reviews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reviews)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Review Management";
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
            this.grid_reviews.Location = new System.Drawing.Point(15, 49);
            this.grid_reviews.MultiSelect = false;
            this.grid_reviews.Name = "grid_reviews";
            this.grid_reviews.ReadOnly = true;
            this.grid_reviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_reviews.Size = new System.Drawing.Size(545, 386);
            this.grid_reviews.TabIndex = 4;
            this.grid_reviews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_reviews_CellDoubleClick);
            // 
            // ReviewsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_reviews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(570, 450);
            this.Name = "ReviewsPanel";
            this.Text = "ReviewsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.grid_reviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_reviews;
    }
}