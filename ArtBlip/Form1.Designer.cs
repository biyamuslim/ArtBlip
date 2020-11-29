namespace Login_form
{
    partial class Form1
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
            this.textUserName = new System.Windows.Forms.TextBox();
            this.CMDSignUp = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.HavenotAccount = new System.Windows.Forms.Label();
            this.ForMore = new System.Windows.Forms.Label();
            this.CMDLogin = new System.Windows.Forms.Button();
            this.CMDAbout = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textBlipArt = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.DarkCyan;
            this.UserName.Location = new System.Drawing.Point(130, 195);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(81, 19);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // textUserName
            // 
            this.textUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColor = System.Drawing.Color.Gray;
            this.textUserName.Location = new System.Drawing.Point(253, 197);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(117, 20);
            this.textUserName.TabIndex = 4;
            this.textUserName.Text = "UserName";
            // 
            // CMDSignUp
            // 
            this.CMDSignUp.BackColor = System.Drawing.SystemColors.Window;
            this.CMDSignUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDSignUp.ForeColor = System.Drawing.Color.DarkCyan;
            this.CMDSignUp.Location = new System.Drawing.Point(308, 388);
            this.CMDSignUp.Name = "CMDSignUp";
            this.CMDSignUp.Size = new System.Drawing.Size(77, 24);
            this.CMDSignUp.TabIndex = 7;
            this.CMDSignUp.Tag = "";
            this.CMDSignUp.Text = "SignUp";
            this.CMDSignUp.UseVisualStyleBackColor = false;
            this.CMDSignUp.Click += new System.EventHandler(this.CMDSignUp_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DarkCyan;
            this.Password.Location = new System.Drawing.Point(139, 234);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 19);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            // 
            // HavenotAccount
            // 
            this.HavenotAccount.AutoSize = true;
            this.HavenotAccount.BackColor = System.Drawing.SystemColors.Window;
            this.HavenotAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HavenotAccount.ForeColor = System.Drawing.Color.DarkCyan;
            this.HavenotAccount.Location = new System.Drawing.Point(97, 393);
            this.HavenotAccount.Name = "HavenotAccount";
            this.HavenotAccount.Size = new System.Drawing.Size(143, 19);
            this.HavenotAccount.TabIndex = 10;
            this.HavenotAccount.Text = "Have\'t Account Yet?";
            // 
            // ForMore
            // 
            this.ForMore.AutoSize = true;
            this.ForMore.BackColor = System.Drawing.SystemColors.Window;
            this.ForMore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForMore.ForeColor = System.Drawing.Color.DarkCyan;
            this.ForMore.Location = new System.Drawing.Point(82, 424);
            this.ForMore.Name = "ForMore";
            this.ForMore.Size = new System.Drawing.Size(158, 19);
            this.ForMore.TabIndex = 11;
            this.ForMore.Text = "For more  information.";
            // 
            // CMDLogin
            // 
            this.CMDLogin.BackColor = System.Drawing.SystemColors.Window;
            this.CMDLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDLogin.ForeColor = System.Drawing.Color.DarkCyan;
            this.CMDLogin.Location = new System.Drawing.Point(183, 298);
            this.CMDLogin.Name = "CMDLogin";
            this.CMDLogin.Size = new System.Drawing.Size(96, 34);
            this.CMDLogin.TabIndex = 12;
            this.CMDLogin.Tag = "";
            this.CMDLogin.Text = "LogIn";
            this.CMDLogin.UseVisualStyleBackColor = false;
            this.CMDLogin.Click += new System.EventHandler(this.CMDLogin_Click);
            // 
            // CMDAbout
            // 
            this.CMDAbout.BackColor = System.Drawing.SystemColors.Window;
            this.CMDAbout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDAbout.ForeColor = System.Drawing.Color.DarkCyan;
            this.CMDAbout.Location = new System.Drawing.Point(308, 418);
            this.CMDAbout.Name = "CMDAbout";
            this.CMDAbout.Size = new System.Drawing.Size(77, 25);
            this.CMDAbout.TabIndex = 13;
            this.CMDAbout.Tag = "";
            this.CMDAbout.Text = "about";
            this.CMDAbout.UseVisualStyleBackColor = false;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Gray;
            this.textPassword.Location = new System.Drawing.Point(253, 235);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(117, 20);
            this.textPassword.TabIndex = 14;
            this.textPassword.Text = "********";
            // 
            // textBlipArt
            // 
            this.textBlipArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBlipArt.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBlipArt.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBlipArt.Location = new System.Drawing.Point(2, 1);
            this.textBlipArt.Multiline = true;
            this.textBlipArt.Name = "textBlipArt";
            this.textBlipArt.Size = new System.Drawing.Size(474, 38);
            this.textBlipArt.TabIndex = 15;
            this.textBlipArt.Text = "Welcome to ArtBlip";
            this.textBlipArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.flowers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 467);
            this.Controls.Add(this.textBlipArt);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.CMDAbout);
            this.Controls.Add(this.CMDLogin);
            this.Controls.Add(this.ForMore);
            this.Controls.Add(this.HavenotAccount);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.CMDSignUp);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Button CMDSignUp;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label HavenotAccount;
        private System.Windows.Forms.Label ForMore;
        private System.Windows.Forms.Button CMDLogin;
        private System.Windows.Forms.Button CMDAbout;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textBlipArt;
        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
    }
}

