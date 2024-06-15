namespace tourist_spot_management_system.Panels
{
    partial class FavouritesPanel
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
            this.label3 = new System.Windows.Forms.Label();
            this.grid_places = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_places)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Favourite Places";
            // 
            // grid_places
            // 
            this.grid_places.AllowUserToAddRows = false;
            this.grid_places.AllowUserToDeleteRows = false;
            this.grid_places.AllowUserToResizeRows = false;
            this.grid_places.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_places.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_places.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grid_places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_places.GridColor = System.Drawing.Color.Azure;
            this.grid_places.Location = new System.Drawing.Point(14, 42);
            this.grid_places.MultiSelect = false;
            this.grid_places.Name = "grid_places";
            this.grid_places.ReadOnly = true;
            this.grid_places.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_places.Size = new System.Drawing.Size(810, 336);
            this.grid_places.TabIndex = 4;
            this.grid_places.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_places_CellDoubleClick);
            // 
            // FavouritesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(834, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_places);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(834, 392);
            this.Name = "FavouritesPanel";
            this.Text = "FavouritesPanel";
            ((System.ComponentModel.ISupportInitialize)(this.grid_places)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid_places;
    }
}