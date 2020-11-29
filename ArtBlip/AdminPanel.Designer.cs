namespace Login_form
{
    partial class AdminPanel
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
            this.CMDStoreCustomer = new System.Windows.Forms.Button();
            this.CMDDeleteArtwork = new System.Windows.Forms.Button();
            this.CMDStoreArtist = new System.Windows.Forms.Button();
            this.CMDStoreArtwork = new System.Windows.Forms.Button();
            this.ArtBlip = new System.Windows.Forms.Label();
            this.CMDManageUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMDStoreCustomer
            // 
            this.CMDStoreCustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CMDStoreCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.CMDStoreCustomer.ForeColor = System.Drawing.Color.Navy;
            this.CMDStoreCustomer.Location = new System.Drawing.Point(68, 163);
            this.CMDStoreCustomer.Name = "CMDStoreCustomer";
            this.CMDStoreCustomer.Size = new System.Drawing.Size(151, 41);
            this.CMDStoreCustomer.TabIndex = 0;
            this.CMDStoreCustomer.Text = " Customer";
            this.CMDStoreCustomer.UseVisualStyleBackColor = false;
            this.CMDStoreCustomer.Click += new System.EventHandler(this.CMDStoreCustomer_Click);
            // 
            // CMDDeleteArtwork
            // 
            this.CMDDeleteArtwork.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CMDDeleteArtwork.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.CMDDeleteArtwork.ForeColor = System.Drawing.Color.Navy;
            this.CMDDeleteArtwork.Location = new System.Drawing.Point(258, 269);
            this.CMDDeleteArtwork.Name = "CMDDeleteArtwork";
            this.CMDDeleteArtwork.Size = new System.Drawing.Size(151, 41);
            this.CMDDeleteArtwork.TabIndex = 0;
            this.CMDDeleteArtwork.Text = "Employees";
            this.CMDDeleteArtwork.UseVisualStyleBackColor = false;
            this.CMDDeleteArtwork.Click += new System.EventHandler(this.CMDDeleteArtwork_Click);
            // 
            // CMDStoreArtist
            // 
            this.CMDStoreArtist.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CMDStoreArtist.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDStoreArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CMDStoreArtist.Location = new System.Drawing.Point(68, 247);
            this.CMDStoreArtist.Name = "CMDStoreArtist";
            this.CMDStoreArtist.Size = new System.Drawing.Size(151, 63);
            this.CMDStoreArtist.TabIndex = 1;
            this.CMDStoreArtist.Text = " Artist";
            this.CMDStoreArtist.UseVisualStyleBackColor = false;
            this.CMDStoreArtist.Click += new System.EventHandler(this.CMDStoreArtist_Click);
            // 
            // CMDStoreArtwork
            // 
            this.CMDStoreArtwork.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CMDStoreArtwork.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDStoreArtwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CMDStoreArtwork.Location = new System.Drawing.Point(258, 163);
            this.CMDStoreArtwork.Name = "CMDStoreArtwork";
            this.CMDStoreArtwork.Size = new System.Drawing.Size(151, 63);
            this.CMDStoreArtwork.TabIndex = 1;
            this.CMDStoreArtwork.Text = "Artwork";
            this.CMDStoreArtwork.UseVisualStyleBackColor = false;
            this.CMDStoreArtwork.Click += new System.EventHandler(this.CMDStoreArtwork_Click);
            // 
            // ArtBlip
            // 
            this.ArtBlip.AutoSize = true;
            this.ArtBlip.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ArtBlip.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtBlip.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ArtBlip.Location = new System.Drawing.Point(167, 30);
            this.ArtBlip.Name = "ArtBlip";
            this.ArtBlip.Size = new System.Drawing.Size(121, 36);
            this.ArtBlip.TabIndex = 2;
            this.ArtBlip.Text = "ArtBlip";
            this.ArtBlip.Click += new System.EventHandler(this.ArtBlip_Click);
            // 
            // CMDManageUsers
            // 
            this.CMDManageUsers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CMDManageUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CMDManageUsers.Location = new System.Drawing.Point(117, 356);
            this.CMDManageUsers.Name = "CMDManageUsers";
            this.CMDManageUsers.Size = new System.Drawing.Size(246, 39);
            this.CMDManageUsers.TabIndex = 3;
            this.CMDManageUsers.Text = "Manage System Users";
            this.CMDManageUsers.UseVisualStyleBackColor = false;
            this.CMDManageUsers.Click += new System.EventHandler(this.CMDManageUsers_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.girlunderwater;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 467);
            this.Controls.Add(this.CMDManageUsers);
            this.Controls.Add(this.ArtBlip);
            this.Controls.Add(this.CMDStoreArtwork);
            this.Controls.Add(this.CMDStoreArtist);
            this.Controls.Add(this.CMDDeleteArtwork);
            this.Controls.Add(this.CMDStoreCustomer);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDStoreCustomer;
        private System.Windows.Forms.Button CMDDeleteArtwork;
        private System.Windows.Forms.Button CMDStoreArtist;
        private System.Windows.Forms.Button CMDStoreArtwork;
        private System.Windows.Forms.Label ArtBlip;
        private System.Windows.Forms.Button CMDManageUsers;
    }
}