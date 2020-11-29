namespace Login_form
{
    partial class StoreArtwork
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
            this.ArtBlip = new System.Windows.Forms.Label();
            this.ArtworkTitle = new System.Windows.Forms.Label();
            this.ArtworkID = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.ArtworkPrice = new System.Windows.Forms.Label();
            this.textArtworkName = new System.Windows.Forms.TextBox();
            this.textArtworkID = new System.Windows.Forms.TextBox();
            this.textArtworkPrice = new System.Windows.Forms.TextBox();
            this.CMDStore = new System.Windows.Forms.Button();
            this.CMDBack = new System.Windows.Forms.Button();
            this.textArtistID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.CMDDelete = new System.Windows.Forms.Button();
            this.CMDUpdate = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artwork_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_made = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtBlip
            // 
            this.ArtBlip.AutoSize = true;
            this.ArtBlip.BackColor = System.Drawing.Color.Transparent;
            this.ArtBlip.Font = new System.Drawing.Font("Kristen ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtBlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArtBlip.Location = new System.Drawing.Point(75, 9);
            this.ArtBlip.Name = "ArtBlip";
            this.ArtBlip.Size = new System.Drawing.Size(293, 33);
            this.ArtBlip.TabIndex = 5;
            this.ArtBlip.Text = "ArtBlip ArtWork Info\r\n";
            // 
            // ArtworkTitle
            // 
            this.ArtworkTitle.AutoSize = true;
            this.ArtworkTitle.BackColor = System.Drawing.Color.Transparent;
            this.ArtworkTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtworkTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.ArtworkTitle.Location = new System.Drawing.Point(77, 178);
            this.ArtworkTitle.Name = "ArtworkTitle";
            this.ArtworkTitle.Size = new System.Drawing.Size(40, 19);
            this.ArtworkTitle.TabIndex = 22;
            this.ArtworkTitle.Text = "Title";
            this.ArtworkTitle.Click += new System.EventHandler(this.ArtworkTitle_Click);
            // 
            // ArtworkID
            // 
            this.ArtworkID.AutoSize = true;
            this.ArtworkID.BackColor = System.Drawing.Color.Transparent;
            this.ArtworkID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtworkID.ForeColor = System.Drawing.SystemColors.Window;
            this.ArtworkID.Location = new System.Drawing.Point(37, 229);
            this.ArtworkID.Name = "ArtworkID";
            this.ArtworkID.Size = new System.Drawing.Size(86, 19);
            this.ArtworkID.TabIndex = 23;
            this.ArtworkID.Text = "Artwork ID";
            this.ArtworkID.Click += new System.EventHandler(this.ArtworkID_Click);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BackColor = System.Drawing.Color.Transparent;
            this.Year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.ForeColor = System.Drawing.SystemColors.Window;
            this.Year.Location = new System.Drawing.Point(63, 322);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(43, 19);
            this.Year.TabIndex = 24;
            this.Year.Text = "Year ";
            this.Year.Click += new System.EventHandler(this.Year_Click);
            // 
            // ArtworkPrice
            // 
            this.ArtworkPrice.AutoSize = true;
            this.ArtworkPrice.BackColor = System.Drawing.Color.Transparent;
            this.ArtworkPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtworkPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.ArtworkPrice.Location = new System.Drawing.Point(63, 359);
            this.ArtworkPrice.Name = "ArtworkPrice";
            this.ArtworkPrice.Size = new System.Drawing.Size(43, 19);
            this.ArtworkPrice.TabIndex = 25;
            this.ArtworkPrice.Text = "Price";
            this.ArtworkPrice.Click += new System.EventHandler(this.ArtworkPrice_Click);
            // 
            // textArtworkName
            // 
            this.textArtworkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArtworkName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtworkName.ForeColor = System.Drawing.Color.Gray;
            this.textArtworkName.Location = new System.Drawing.Point(172, 178);
            this.textArtworkName.Name = "textArtworkName";
            this.textArtworkName.Size = new System.Drawing.Size(131, 20);
            this.textArtworkName.TabIndex = 26;
            this.textArtworkName.Text = "Name";
            this.textArtworkName.TextChanged += new System.EventHandler(this.textArtworkName_TextChanged);
            // 
            // textArtworkID
            // 
            this.textArtworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArtworkID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtworkID.ForeColor = System.Drawing.Color.Gray;
            this.textArtworkID.Location = new System.Drawing.Point(172, 228);
            this.textArtworkID.Name = "textArtworkID";
            this.textArtworkID.Size = new System.Drawing.Size(131, 20);
            this.textArtworkID.TabIndex = 27;
            this.textArtworkID.Text = "ID";
            this.textArtworkID.TextChanged += new System.EventHandler(this.textArtworkID_TextChanged);
            // 
            // textArtworkPrice
            // 
            this.textArtworkPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArtworkPrice.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtworkPrice.ForeColor = System.Drawing.Color.Gray;
            this.textArtworkPrice.Location = new System.Drawing.Point(172, 361);
            this.textArtworkPrice.Name = "textArtworkPrice";
            this.textArtworkPrice.Size = new System.Drawing.Size(131, 20);
            this.textArtworkPrice.TabIndex = 29;
            this.textArtworkPrice.Text = "Price";
            // 
            // CMDStore
            // 
            this.CMDStore.BackColor = System.Drawing.Color.ForestGreen;
            this.CMDStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDStore.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDStore.Location = new System.Drawing.Point(172, 413);
            this.CMDStore.Name = "CMDStore";
            this.CMDStore.Size = new System.Drawing.Size(88, 38);
            this.CMDStore.TabIndex = 30;
            this.CMDStore.Tag = "";
            this.CMDStore.Text = "Store";
            this.CMDStore.UseVisualStyleBackColor = false;
            this.CMDStore.Click += new System.EventHandler(this.CMDStore_Click);
            // 
            // CMDBack
            // 
            this.CMDBack.BackColor = System.Drawing.Color.ForestGreen;
            this.CMDBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDBack.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDBack.Location = new System.Drawing.Point(67, 413);
            this.CMDBack.Name = "CMDBack";
            this.CMDBack.Size = new System.Drawing.Size(70, 28);
            this.CMDBack.TabIndex = 31;
            this.CMDBack.Tag = "";
            this.CMDBack.Text = "Back";
            this.CMDBack.UseVisualStyleBackColor = false;
            this.CMDBack.Click += new System.EventHandler(this.CMDBack_Click);
            // 
            // textArtistID
            // 
            this.textArtistID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArtistID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtistID.ForeColor = System.Drawing.Color.Gray;
            this.textArtistID.Location = new System.Drawing.Point(172, 272);
            this.textArtistID.Name = "textArtistID";
            this.textArtistID.Size = new System.Drawing.Size(131, 20);
            this.textArtistID.TabIndex = 32;
            this.textArtistID.Text = "ID";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.Window;
            this.ID.Location = new System.Drawing.Point(54, 272);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(69, 19);
            this.ID.TabIndex = 33;
            this.ID.Text = "Artist ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 321);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Artwork_ID,
            this.Artist_ID,
            this.YEAR_made,
            this.PRICE});
            this.dataGridView2.Location = new System.Drawing.Point(418, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(498, 272);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(420, 422);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(78, 20);
            this.txtSearch.TabIndex = 41;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(522, 422);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 40;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CMDDelete
            // 
            this.CMDDelete.Location = new System.Drawing.Point(728, 422);
            this.CMDDelete.Name = "CMDDelete";
            this.CMDDelete.Size = new System.Drawing.Size(75, 23);
            this.CMDDelete.TabIndex = 39;
            this.CMDDelete.Text = "Delete";
            this.CMDDelete.UseVisualStyleBackColor = true;
            this.CMDDelete.Click += new System.EventHandler(this.CMDDelete_Click);
            // 
            // CMDUpdate
            // 
            this.CMDUpdate.Location = new System.Drawing.Point(625, 422);
            this.CMDUpdate.Name = "CMDUpdate";
            this.CMDUpdate.Size = new System.Drawing.Size(75, 23);
            this.CMDUpdate.TabIndex = 38;
            this.CMDUpdate.Text = "Update";
            this.CMDUpdate.UseVisualStyleBackColor = true;
            this.CMDUpdate.Click += new System.EventHandler(this.CMDUpdate_Click);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Artwork_ID
            // 
            this.Artwork_ID.HeaderText = "ArtworkID";
            this.Artwork_ID.Name = "Artwork_ID";
            // 
            // Artist_ID
            // 
            this.Artist_ID.HeaderText = "AristID";
            this.Artist_ID.Name = "Artist_ID";
            // 
            // YEAR_made
            // 
            this.YEAR_made.HeaderText = "YEAR";
            this.YEAR_made.Name = "YEAR_made";
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Price";
            this.PRICE.Name = "PRICE";
            // 
            // StoreArtwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.michkal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 470);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.CMDDelete);
            this.Controls.Add(this.CMDUpdate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textArtistID);
            this.Controls.Add(this.CMDBack);
            this.Controls.Add(this.CMDStore);
            this.Controls.Add(this.textArtworkPrice);
            this.Controls.Add(this.textArtworkID);
            this.Controls.Add(this.textArtworkName);
            this.Controls.Add(this.ArtworkPrice);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.ArtworkID);
            this.Controls.Add(this.ArtworkTitle);
            this.Controls.Add(this.ArtBlip);
            this.Name = "StoreArtwork";
            this.Text = "StoreArtwork";
            this.Load += new System.EventHandler(this.StoreArtwork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArtBlip;
        private System.Windows.Forms.Label ArtworkTitle;
        private System.Windows.Forms.Label ArtworkID;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label ArtworkPrice;
        private System.Windows.Forms.TextBox textArtworkName;
        private System.Windows.Forms.TextBox textArtworkID;
        private System.Windows.Forms.TextBox textArtworkPrice;
        private System.Windows.Forms.Button CMDStore;
        private System.Windows.Forms.Button CMDBack;
        private System.Windows.Forms.TextBox textArtistID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artwork_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_made;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button CMDDelete;
        private System.Windows.Forms.Button CMDUpdate;
    }
}