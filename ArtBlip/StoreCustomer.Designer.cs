namespace Login_form
{
    partial class StoreCustomer
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.PhoneNO = new System.Windows.Forms.Label();
            this.CardNo = new System.Windows.Forms.Label();
            this.TotalBill = new System.Windows.Forms.Label();
            this.CMDStore = new System.Windows.Forms.Button();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.textPhoneNo = new System.Windows.Forms.TextBox();
            this.textCardNo = new System.Windows.Forms.TextBox();
            this.textTotalBill = new System.Windows.Forms.TextBox();
            this.CMDBack = new System.Windows.Forms.Button();
            this.textArtworkID = new System.Windows.Forms.TextBox();
            this.ArtworkID = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.CMDDelete = new System.Windows.Forms.Button();
            this.CMDUpdate = new System.Windows.Forms.Button();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_is = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtBlip
            // 
            this.ArtBlip.AutoSize = true;
            this.ArtBlip.BackColor = System.Drawing.Color.Transparent;
            this.ArtBlip.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtBlip.ForeColor = System.Drawing.SystemColors.Window;
            this.ArtBlip.Location = new System.Drawing.Point(68, 9);
            this.ArtBlip.Name = "ArtBlip";
            this.ArtBlip.Size = new System.Drawing.Size(313, 33);
            this.ArtBlip.TabIndex = 3;
            this.ArtBlip.Text = "ArtBlip customer\'s info\r\n";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.CustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.SystemColors.Window;
            this.CustomerName.Location = new System.Drawing.Point(29, 82);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(49, 19);
            this.CustomerName.TabIndex = 4;
            this.CustomerName.Text = "Name";
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.BackColor = System.Drawing.Color.Transparent;
            this.CustomerID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.ForeColor = System.Drawing.SystemColors.Window;
            this.CustomerID.Location = new System.Drawing.Point(12, 121);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(92, 19);
            this.CustomerID.TabIndex = 5;
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Click += new System.EventHandler(this.CustomerID_Click);
            // 
            // PhoneNO
            // 
            this.PhoneNO.AutoSize = true;
            this.PhoneNO.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNO.ForeColor = System.Drawing.SystemColors.Window;
            this.PhoneNO.Location = new System.Drawing.Point(12, 208);
            this.PhoneNO.Name = "PhoneNO";
            this.PhoneNO.Size = new System.Drawing.Size(74, 19);
            this.PhoneNO.TabIndex = 6;
            this.PhoneNO.Text = "Phone No";
            // 
            // CardNo
            // 
            this.CardNo.AutoSize = true;
            this.CardNo.BackColor = System.Drawing.Color.Transparent;
            this.CardNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNo.ForeColor = System.Drawing.SystemColors.Window;
            this.CardNo.Location = new System.Drawing.Point(12, 243);
            this.CardNo.Name = "CardNo";
            this.CardNo.Size = new System.Drawing.Size(66, 19);
            this.CardNo.TabIndex = 7;
            this.CardNo.Text = "Card No";
            // 
            // TotalBill
            // 
            this.TotalBill.AutoSize = true;
            this.TotalBill.BackColor = System.Drawing.Color.Transparent;
            this.TotalBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBill.ForeColor = System.Drawing.SystemColors.Window;
            this.TotalBill.Location = new System.Drawing.Point(12, 292);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(66, 19);
            this.TotalBill.TabIndex = 8;
            this.TotalBill.Text = "Total Bil";
            // 
            // CMDStore
            // 
            this.CMDStore.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CMDStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDStore.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDStore.Location = new System.Drawing.Point(140, 367);
            this.CMDStore.Name = "CMDStore";
            this.CMDStore.Size = new System.Drawing.Size(88, 38);
            this.CMDStore.TabIndex = 18;
            this.CMDStore.Tag = "";
            this.CMDStore.Text = "Store";
            this.CMDStore.UseVisualStyleBackColor = false;
            this.CMDStore.Click += new System.EventHandler(this.CMDStore_Click);
            // 
            // textCustomerName
            // 
            this.textCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCustomerName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustomerName.ForeColor = System.Drawing.Color.Gray;
            this.textCustomerName.Location = new System.Drawing.Point(144, 81);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(131, 20);
            this.textCustomerName.TabIndex = 19;
            this.textCustomerName.Text = "Name";
            // 
            // textCustomerID
            // 
            this.textCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCustomerID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustomerID.ForeColor = System.Drawing.Color.Gray;
            this.textCustomerID.Location = new System.Drawing.Point(144, 120);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(131, 20);
            this.textCustomerID.TabIndex = 20;
            this.textCustomerID.Text = "ID";
            // 
            // textPhoneNo
            // 
            this.textPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPhoneNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNo.ForeColor = System.Drawing.Color.Gray;
            this.textPhoneNo.Location = new System.Drawing.Point(144, 210);
            this.textPhoneNo.Name = "textPhoneNo";
            this.textPhoneNo.Size = new System.Drawing.Size(131, 20);
            this.textPhoneNo.TabIndex = 21;
            this.textPhoneNo.Text = "PhoneNo";
            // 
            // textCardNo
            // 
            this.textCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCardNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardNo.ForeColor = System.Drawing.Color.Gray;
            this.textCardNo.Location = new System.Drawing.Point(140, 245);
            this.textCardNo.Name = "textCardNo";
            this.textCardNo.Size = new System.Drawing.Size(131, 20);
            this.textCardNo.TabIndex = 22;
            this.textCardNo.Text = "CardNo.";
            // 
            // textTotalBill
            // 
            this.textTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTotalBill.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalBill.ForeColor = System.Drawing.Color.Gray;
            this.textTotalBill.Location = new System.Drawing.Point(140, 291);
            this.textTotalBill.Name = "textTotalBill";
            this.textTotalBill.Size = new System.Drawing.Size(131, 20);
            this.textTotalBill.TabIndex = 23;
            this.textTotalBill.Text = "0000";
            // 
            // CMDBack
            // 
            this.CMDBack.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CMDBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDBack.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDBack.Location = new System.Drawing.Point(16, 377);
            this.CMDBack.Name = "CMDBack";
            this.CMDBack.Size = new System.Drawing.Size(70, 28);
            this.CMDBack.TabIndex = 24;
            this.CMDBack.Tag = "";
            this.CMDBack.Text = "Back";
            this.CMDBack.UseVisualStyleBackColor = false;
            this.CMDBack.Click += new System.EventHandler(this.CMDBack_Click_1);
            // 
            // textArtworkID
            // 
            this.textArtworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArtworkID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtworkID.ForeColor = System.Drawing.Color.Gray;
            this.textArtworkID.Location = new System.Drawing.Point(144, 164);
            this.textArtworkID.Name = "textArtworkID";
            this.textArtworkID.Size = new System.Drawing.Size(131, 20);
            this.textArtworkID.TabIndex = 29;
            this.textArtworkID.Text = "ID";
            // 
            // ArtworkID
            // 
            this.ArtworkID.AutoSize = true;
            this.ArtworkID.BackColor = System.Drawing.Color.Transparent;
            this.ArtworkID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtworkID.ForeColor = System.Drawing.SystemColors.Window;
            this.ArtworkID.Location = new System.Drawing.Point(12, 162);
            this.ArtworkID.Name = "ArtworkID";
            this.ArtworkID.Size = new System.Drawing.Size(86, 19);
            this.ArtworkID.TabIndex = 28;
            this.ArtworkID.Text = "Artwork ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cID,
            this.work_id,
            this.Phone_no,
            this.Card_NO,
            this.bill_is});
            this.dataGridView2.Location = new System.Drawing.Point(294, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(646, 272);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(295, 416);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(78, 20);
            this.txtSearch.TabIndex = 45;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(397, 416);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CMDDelete
            // 
            this.CMDDelete.Location = new System.Drawing.Point(603, 416);
            this.CMDDelete.Name = "CMDDelete";
            this.CMDDelete.Size = new System.Drawing.Size(75, 23);
            this.CMDDelete.TabIndex = 43;
            this.CMDDelete.Text = "Delete";
            this.CMDDelete.UseVisualStyleBackColor = true;
            this.CMDDelete.Click += new System.EventHandler(this.CMDDelete_Click);
            // 
            // CMDUpdate
            // 
            this.CMDUpdate.Location = new System.Drawing.Point(500, 416);
            this.CMDUpdate.Name = "CMDUpdate";
            this.CMDUpdate.Size = new System.Drawing.Size(75, 23);
            this.CMDUpdate.TabIndex = 42;
            this.CMDUpdate.Text = "Update";
            this.CMDUpdate.UseVisualStyleBackColor = true;
            this.CMDUpdate.Click += new System.EventHandler(this.CMDUpdate_Click);
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            // 
            // cID
            // 
            this.cID.HeaderText = "CustumerID";
            this.cID.Name = "cID";
            // 
            // work_id
            // 
            this.work_id.HeaderText = "ArtworkID";
            this.work_id.Name = "work_id";
            // 
            // Phone_no
            // 
            this.Phone_no.HeaderText = "Phone No";
            this.Phone_no.Name = "Phone_no";
            // 
            // Card_NO
            // 
            this.Card_NO.HeaderText = "Card No";
            this.Card_NO.Name = "Card_NO";
            // 
            // bill_is
            // 
            this.bill_is.HeaderText = "Bill";
            this.bill_is.Name = "bill_is";
            // 
            // StoreCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.Sitar_Wali_anty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.CMDDelete);
            this.Controls.Add(this.CMDUpdate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textArtworkID);
            this.Controls.Add(this.ArtworkID);
            this.Controls.Add(this.CMDBack);
            this.Controls.Add(this.textTotalBill);
            this.Controls.Add(this.textCardNo);
            this.Controls.Add(this.textPhoneNo);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.CMDStore);
            this.Controls.Add(this.TotalBill);
            this.Controls.Add(this.CardNo);
            this.Controls.Add(this.PhoneNO);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.ArtBlip);
            this.Name = "StoreCustomer";
            this.Text = "StoreCustomer";
            this.Load += new System.EventHandler(this.StoreCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArtBlip;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label PhoneNO;
        private System.Windows.Forms.Label CardNo;
        private System.Windows.Forms.Label TotalBill;
        private System.Windows.Forms.Button CMDStore;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox textPhoneNo;
        private System.Windows.Forms.TextBox textCardNo;
        private System.Windows.Forms.TextBox textTotalBill;
        private System.Windows.Forms.Button CMDBack;
        private System.Windows.Forms.TextBox textArtworkID;
        private System.Windows.Forms.Label ArtworkID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button CMDDelete;
        private System.Windows.Forms.Button CMDUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_is;
    }
}