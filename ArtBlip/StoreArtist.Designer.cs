namespace Login_form
{
    partial class StoreArtist
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
            this.components = new System.ComponentModel.Container();
            this.ArtBlip = new System.Windows.Forms.Label();
            this.textArtistID = new System.Windows.Forms.TextBox();
            this.textArtistName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Typeofart = new System.Windows.Forms.Label();
            this.CMDStore = new System.Windows.Forms.Button();
            this.CMDBack = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboTypeOfArt = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.galleryDataSet1 = new Login_form.GalleryDataSet1();
            this.galleryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet2 = new Login_form.GalleryDataSet2();
            this.galleryDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet = new Login_form.GalleryDataSet();
            this.galleryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CMDUpdate = new System.Windows.Forms.Button();
            this.CMDDelete = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Aritist_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_OF_Art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtBlip
            // 
            this.ArtBlip.AutoSize = true;
            this.ArtBlip.BackColor = System.Drawing.Color.Transparent;
            this.ArtBlip.Font = new System.Drawing.Font("Kristen ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtBlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArtBlip.Location = new System.Drawing.Point(101, 9);
            this.ArtBlip.Name = "ArtBlip";
            this.ArtBlip.Size = new System.Drawing.Size(255, 33);
            this.ArtBlip.TabIndex = 4;
            this.ArtBlip.Text = "ArtBlip Artist info\r\n";
            // 
            // textArtistID
            // 
            this.textArtistID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArtistID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtistID.ForeColor = System.Drawing.Color.Gray;
            this.textArtistID.Location = new System.Drawing.Point(107, 177);
            this.textArtistID.Name = "textArtistID";
            this.textArtistID.Size = new System.Drawing.Size(131, 20);
            this.textArtistID.TabIndex = 24;
            this.textArtistID.Text = "ID";
            // 
            // textArtistName
            // 
            this.textArtistName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArtistName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtistName.ForeColor = System.Drawing.Color.Gray;
            this.textArtistName.Location = new System.Drawing.Point(107, 122);
            this.textArtistName.Name = "textArtistName";
            this.textArtistName.Size = new System.Drawing.Size(131, 20);
            this.textArtistName.TabIndex = 23;
            this.textArtistName.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.Window;
            this.ID.Location = new System.Drawing.Point(12, 175);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(27, 19);
            this.ID.TabIndex = 22;
            this.ID.Text = "ID";
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.BackColor = System.Drawing.Color.Transparent;
            this.ArtistName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.ForeColor = System.Drawing.SystemColors.Window;
            this.ArtistName.Location = new System.Drawing.Point(12, 120);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(49, 19);
            this.ArtistName.TabIndex = 21;
            this.ArtistName.Text = "Name";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.Color.Transparent;
            this.DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.SystemColors.Window;
            this.DOB.Location = new System.Drawing.Point(12, 224);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(44, 19);
            this.DOB.TabIndex = 25;
            this.DOB.Text = "DOB";
            // 
            // Typeofart
            // 
            this.Typeofart.AutoSize = true;
            this.Typeofart.BackColor = System.Drawing.Color.Transparent;
            this.Typeofart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typeofart.ForeColor = System.Drawing.SystemColors.Window;
            this.Typeofart.Location = new System.Drawing.Point(12, 275);
            this.Typeofart.Name = "Typeofart";
            this.Typeofart.Size = new System.Drawing.Size(88, 19);
            this.Typeofart.TabIndex = 27;
            this.Typeofart.Text = "Type Of Art";
            // 
            // CMDStore
            // 
            this.CMDStore.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CMDStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDStore.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDStore.Location = new System.Drawing.Point(107, 341);
            this.CMDStore.Name = "CMDStore";
            this.CMDStore.Size = new System.Drawing.Size(88, 38);
            this.CMDStore.TabIndex = 29;
            this.CMDStore.Tag = "";
            this.CMDStore.Text = "Store";
            this.CMDStore.UseVisualStyleBackColor = false;
            this.CMDStore.Click += new System.EventHandler(this.CMDStore_Click);
            // 
            // CMDBack
            // 
            this.CMDBack.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CMDBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDBack.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDBack.Location = new System.Drawing.Point(16, 351);
            this.CMDBack.Name = "CMDBack";
            this.CMDBack.Size = new System.Drawing.Size(70, 28);
            this.CMDBack.TabIndex = 30;
            this.CMDBack.Tag = "";
            this.CMDBack.Text = "Back";
            this.CMDBack.UseVisualStyleBackColor = false;
            this.CMDBack.Click += new System.EventHandler(this.CMDBack_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboTypeOfArt
            // 
            this.comboTypeOfArt.FormattingEnabled = true;
            this.comboTypeOfArt.Items.AddRange(new object[] {
            "Abstract",
            "Nature",
            "Pop",
            "Impressionism",
            "Fauvism",
            "ALL"});
            this.comboTypeOfArt.Location = new System.Drawing.Point(107, 273);
            this.comboTypeOfArt.Name = "comboTypeOfArt";
            this.comboTypeOfArt.Size = new System.Drawing.Size(131, 21);
            this.comboTypeOfArt.TabIndex = 32;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aritist_Name,
            this.Artist_ID,
            this.Artist_DOB,
            this.Type_OF_Art});
            this.dataGridView2.Location = new System.Drawing.Point(255, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(425, 272);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // galleryDataSet1
            // 
            this.galleryDataSet1.DataSetName = "GalleryDataSet1";
            this.galleryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // galleryDataSet1BindingSource
            // 
            this.galleryDataSet1BindingSource.DataSource = this.galleryDataSet1;
            this.galleryDataSet1BindingSource.Position = 0;
            // 
            // galleryDataSet2
            // 
            this.galleryDataSet2.DataSetName = "GalleryDataSet2";
            this.galleryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // galleryDataSet2BindingSource
            // 
            this.galleryDataSet2BindingSource.DataSource = this.galleryDataSet2;
            this.galleryDataSet2BindingSource.Position = 0;
            // 
            // galleryDataSet
            // 
            this.galleryDataSet.DataSetName = "GalleryDataSet";
            this.galleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // galleryDataSetBindingSource
            // 
            this.galleryDataSetBindingSource.DataSource = this.galleryDataSet;
            this.galleryDataSetBindingSource.Position = 0;
            // 
            // CMDUpdate
            // 
            this.CMDUpdate.Location = new System.Drawing.Point(468, 406);
            this.CMDUpdate.Name = "CMDUpdate";
            this.CMDUpdate.Size = new System.Drawing.Size(75, 23);
            this.CMDUpdate.TabIndex = 34;
            this.CMDUpdate.Text = "Update";
            this.CMDUpdate.UseVisualStyleBackColor = true;
            this.CMDUpdate.Click += new System.EventHandler(this.CMDUpdate_Click);
            // 
            // CMDDelete
            // 
            this.CMDDelete.Location = new System.Drawing.Point(573, 406);
            this.CMDDelete.Name = "CMDDelete";
            this.CMDDelete.Size = new System.Drawing.Size(75, 23);
            this.CMDDelete.TabIndex = 35;
            this.CMDDelete.Text = "Delete";
            this.CMDDelete.UseVisualStyleBackColor = true;
            this.CMDDelete.Click += new System.EventHandler(this.CMDDelete_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(362, 406);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 36;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(255, 406);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(78, 20);
            this.txtSearch.TabIndex = 37;
            // 
            // Aritist_Name
            // 
            this.Aritist_Name.HeaderText = "Artist Name";
            this.Aritist_Name.Name = "Aritist_Name";
            // 
            // Artist_ID
            // 
            this.Artist_ID.HeaderText = "AristID";
            this.Artist_ID.Name = "Artist_ID";
            // 
            // Artist_DOB
            // 
            this.Artist_DOB.HeaderText = "DOB";
            this.Artist_DOB.Name = "Artist_DOB";
            // 
            // Type_OF_Art
            // 
            this.Type_OF_Art.HeaderText = "ART Type";
            this.Type_OF_Art.Name = "Type_OF_Art";
            // 
            // StoreArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Login_form.Properties.Resources.red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 470);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.CMDDelete);
            this.Controls.Add(this.CMDUpdate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboTypeOfArt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CMDBack);
            this.Controls.Add(this.CMDStore);
            this.Controls.Add(this.Typeofart);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.textArtistID);
            this.Controls.Add(this.textArtistName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.ArtBlip);
            this.Name = "StoreArtist";
            this.Text = "StoreArtist";
            this.Load += new System.EventHandler(this.StoreArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArtBlip;
        private System.Windows.Forms.TextBox textArtistID;
        private System.Windows.Forms.TextBox textArtistName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label ArtistName;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Typeofart;
        private System.Windows.Forms.Button CMDStore;
        private System.Windows.Forms.Button CMDBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboTypeOfArt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource galleryDataSet1BindingSource;
        private GalleryDataSet1 galleryDataSet1;
        private GalleryDataSet2 galleryDataSet2;
        private System.Windows.Forms.BindingSource galleryDataSet2BindingSource;
        private GalleryDataSet galleryDataSet;
        private System.Windows.Forms.BindingSource galleryDataSetBindingSource;
        private System.Windows.Forms.Button CMDUpdate;
        private System.Windows.Forms.Button CMDDelete;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aritist_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_OF_Art;
    }
}