namespace tourist_spot_management_system.Panels
{
    partial class SpotsPanel
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
            this.btn_add_spot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_spots = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_spots)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_spot
            // 
            this.btn_add_spot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_spot.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add_spot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_spot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_spot.ForeColor = System.Drawing.Color.Azure;
            this.btn_add_spot.Location = new System.Drawing.Point(433, 12);
            this.btn_add_spot.Name = "btn_add_spot";
            this.btn_add_spot.Size = new System.Drawing.Size(127, 34);
            this.btn_add_spot.TabIndex = 9;
            this.btn_add_spot.Text = "Add New Spot";
            this.btn_add_spot.UseVisualStyleBackColor = false;
            this.btn_add_spot.Click += new System.EventHandler(this.btn_add_spot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Spot Management";
            // 
            // grid_spots
            // 
            this.grid_spots.AllowUserToAddRows = false;
            this.grid_spots.AllowUserToDeleteRows = false;
            this.grid_spots.AllowUserToResizeRows = false;
            this.grid_spots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_spots.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_spots.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grid_spots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_spots.GridColor = System.Drawing.Color.Azure;
            this.grid_spots.Location = new System.Drawing.Point(15, 52);
            this.grid_spots.MultiSelect = false;
            this.grid_spots.Name = "grid_spots";
            this.grid_spots.ReadOnly = true;
            this.grid_spots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_spots.Size = new System.Drawing.Size(545, 386);
            this.grid_spots.TabIndex = 4;
            this.grid_spots.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_spots_CellDoubleClick);
            // 
            // SpotsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btn_add_spot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_spots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(570, 450);
            this.Name = "SpotsPanel";
            this.Text = "SpotsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.grid_spots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_spot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_spots;
    }
}