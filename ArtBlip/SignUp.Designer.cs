namespace Login_form
{
    partial class SignUp
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
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.CMDSignUp = new System.Windows.Forms.Button();
            this.CMDBack = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.ArtBlip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.DarkCyan;
            this.UserName.Location = new System.Drawing.Point(118, 197);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(81, 19);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "UserName";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DarkCyan;
            this.Password.Location = new System.Drawing.Point(118, 291);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 19);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // textUserName
            // 
            this.textUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColor = System.Drawing.Color.Gray;
            this.textUserName.Location = new System.Drawing.Point(225, 199);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(131, 20);
            this.textUserName.TabIndex = 9;
            this.textUserName.Text = "UserName";
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.Gray;
            this.textEmail.Location = new System.Drawing.Point(225, 243);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(131, 20);
            this.textEmail.TabIndex = 11;
            this.textEmail.Text = "xyz@gmail.com";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Gray;
            this.textPassword.Location = new System.Drawing.Point(225, 291);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(131, 20);
            this.textPassword.TabIndex = 15;
            this.textPassword.Text = "********";
            // 
            // CMDSignUp
            // 
            this.CMDSignUp.BackColor = System.Drawing.SystemColors.Window;
            this.CMDSignUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDSignUp.ForeColor = System.Drawing.Color.DarkCyan;
            this.CMDSignUp.Location = new System.Drawing.Point(225, 338);
            this.CMDSignUp.Name = "CMDSignUp";
            this.CMDSignUp.Size = new System.Drawing.Size(88, 38);
            this.CMDSignUp.TabIndex = 17;
            this.CMDSignUp.Tag = "";
            this.CMDSignUp.Text = "SignUp";
            this.CMDSignUp.UseVisualStyleBackColor = false;
            this.CMDSignUp.Click += new System.EventHandler(this.CMDSignUp_Click);
            // 
            // CMDBack
            // 
            this.CMDBack.BackColor = System.Drawing.SystemColors.Window;
            this.CMDBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDBack.ForeColor = System.Drawing.Color.DarkCyan;
            this.CMDBack.Location = new System.Drawing.Point(122, 352);
            this.CMDBack.Name = "CMDBack";
            this.CMDBack.Size = new System.Drawing.Size(69, 24);
            this.CMDBack.TabIndex = 18;
            this.CMDBack.Tag = "";
            this.CMDBack.Text = "back";
            this.CMDBack.UseVisualStyleBackColor = false;
            this.CMDBack.Click += new System.EventHandler(this.CMDBack_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.DarkCyan;
            this.email.Location = new System.Drawing.Point(129, 241);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(45, 19);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            // 
            // ArtBlip
            // 
            this.ArtBlip.AutoSize = true;
            this.ArtBlip.BackColor = System.Drawing.SystemColors.Window;
            this.ArtBlip.Font = new System.Drawing.Font("Kristen ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtBlip.ForeColor = System.Drawing.Color.DarkCyan;
            this.ArtBlip.Location = new System.Drawing.Point(12, 9);
            this.ArtBlip.Name = "ArtBlip";
            this.ArtBlip.Size = new System.Drawing.Size(442, 36);
            this.ArtBlip.TabIndex = 19;
            this.ArtBlip.Text = "SIgnup & have Fun with ArtBlip\r\n";
            this.ArtBlip.Click += new System.EventHandler(this.ArtBlip_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.flowers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 467);
            this.Controls.Add(this.ArtBlip);
            this.Controls.Add(this.CMDBack);
            this.Controls.Add(this.CMDSignUp);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.UserName);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button CMDSignUp;
        private System.Windows.Forms.Button CMDBack;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label ArtBlip;
    }
}