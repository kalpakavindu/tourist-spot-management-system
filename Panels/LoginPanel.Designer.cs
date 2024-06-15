namespace tourist_spot_management_system.Panels
{
    partial class LoginPanel
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
            this.btn_signin = new System.Windows.Forms.Button();
            this.toggle_password = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toggle_password)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.Azure;
            this.btn_signin.Location = new System.Drawing.Point(69, 255);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(111, 34);
            this.btn_signin.TabIndex = 29;
            this.btn_signin.Text = "Sign in";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // toggle_password
            // 
            this.toggle_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggle_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggle_password.Image = global::tourist_spot_management_system.Properties.Resources.eye;
            this.toggle_password.InitialImage = global::tourist_spot_management_system.Properties.Resources.eye;
            this.toggle_password.Location = new System.Drawing.Point(376, 205);
            this.toggle_password.Name = "toggle_password";
            this.toggle_password.Size = new System.Drawing.Size(27, 22);
            this.toggle_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toggle_password.TabIndex = 28;
            this.toggle_password.TabStop = false;
            this.toggle_password.Click += new System.EventHandler(this.toggle_password_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // input_password
            // 
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.Location = new System.Drawing.Point(69, 205);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(301, 22);
            this.input_password.TabIndex = 26;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email Address";
            // 
            // input_email
            // 
            this.input_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_email.Location = new System.Drawing.Point(69, 146);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(334, 22);
            this.input_email.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sign In";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(467, 365);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.toggle_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPanel";
            this.Text = "LoginPanel";
            ((System.ComponentModel.ISupportInitialize)(this.toggle_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.PictureBox toggle_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label1;
    }
}