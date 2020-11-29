namespace Login_form
{
    partial class manageUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passsword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDUpdate = new System.Windows.Forms.Button();
            this.CMDDelete = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.CMDBack = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsersName,
            this.Emails,
            this.Passsword});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 316);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // UsersName
            // 
            this.UsersName.HeaderText = "User Name";
            this.UsersName.Name = "UsersName";
            // 
            // Emails
            // 
            this.Emails.HeaderText = "Emails";
            this.Emails.Name = "Emails";
            // 
            // Passsword
            // 
            this.Passsword.HeaderText = "Password";
            this.Passsword.Name = "Passsword";
            // 
            // CMDUpdate
            // 
            this.CMDUpdate.Location = new System.Drawing.Point(508, 379);
            this.CMDUpdate.Name = "CMDUpdate";
            this.CMDUpdate.Size = new System.Drawing.Size(75, 23);
            this.CMDUpdate.TabIndex = 28;
            this.CMDUpdate.Text = "Update";
            this.CMDUpdate.UseVisualStyleBackColor = true;
            this.CMDUpdate.Click += new System.EventHandler(this.CMDUpdate_Click);
            // 
            // CMDDelete
            // 
            this.CMDDelete.Location = new System.Drawing.Point(628, 380);
            this.CMDDelete.Name = "CMDDelete";
            this.CMDDelete.Size = new System.Drawing.Size(75, 23);
            this.CMDDelete.TabIndex = 27;
            this.CMDDelete.Text = "Delete";
            this.CMDDelete.UseVisualStyleBackColor = true;
            this.CMDDelete.Click += new System.EventHandler(this.CMDDelete_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(628, 411);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(508, 415);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(78, 20);
            this.txtSearch.TabIndex = 25;
            // 
            // CMDBack
            // 
            this.CMDBack.BackColor = System.Drawing.SystemColors.Window;
            this.CMDBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDBack.ForeColor = System.Drawing.Color.DarkCyan;
            this.CMDBack.Location = new System.Drawing.Point(59, 409);
            this.CMDBack.Name = "CMDBack";
            this.CMDBack.Size = new System.Drawing.Size(80, 24);
            this.CMDBack.TabIndex = 29;
            this.CMDBack.Tag = "";
            this.CMDBack.Text = "back";
            this.CMDBack.UseVisualStyleBackColor = false;
            this.CMDBack.Click += new System.EventHandler(this.CMDBack_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Gray;
            this.textPassword.Location = new System.Drawing.Point(583, 310);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(131, 20);
            this.textPassword.TabIndex = 35;
            this.textPassword.Text = "********";
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.Gray;
            this.textEmail.Location = new System.Drawing.Point(583, 262);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(131, 20);
            this.textEmail.TabIndex = 34;
            this.textEmail.Text = "xyz@gmail.com";
            // 
            // textUserName
            // 
            this.textUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColor = System.Drawing.Color.Gray;
            this.textUserName.Location = new System.Drawing.Point(583, 215);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(131, 20);
            this.textUserName.TabIndex = 33;
            this.textUserName.Text = "UserName";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Password.Location = new System.Drawing.Point(476, 310);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 19);
            this.Password.TabIndex = 32;
            this.Password.Text = "Password";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Fuchsia;
            this.email.Location = new System.Drawing.Point(487, 260);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(45, 19);
            this.email.TabIndex = 31;
            this.email.Text = "email";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UserName.Location = new System.Drawing.Point(476, 216);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(81, 19);
            this.UserName.TabIndex = 30;
            this.UserName.Text = "UserName";
            // 
            // manageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.dacing_women;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.CMDBack);
            this.Controls.Add(this.CMDUpdate);
            this.Controls.Add(this.CMDDelete);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "manageUser";
            this.Text = "manageUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passsword;
        private System.Windows.Forms.Button CMDUpdate;
        private System.Windows.Forms.Button CMDDelete;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button CMDBack;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label UserName;
    }
}