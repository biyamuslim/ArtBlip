namespace Login_form
{
    partial class DeleteArtwork
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
            this.employeeID = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.employeePosition = new System.Windows.Forms.Label();
            this.textEmployeeID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textCNIC = new System.Windows.Forms.TextBox();
            this.CMDSave = new System.Windows.Forms.Button();
            this.CMDBack = new System.Windows.Forms.Button();
            this.textContactNo = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DOB = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.CMDDelete = new System.Windows.Forms.Button();
            this.CMDUpdate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Join = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtBlip
            // 
            this.ArtBlip.AutoSize = true;
            this.ArtBlip.BackColor = System.Drawing.Color.Transparent;
            this.ArtBlip.Font = new System.Drawing.Font("Kristen ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtBlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ArtBlip.Location = new System.Drawing.Point(108, 9);
            this.ArtBlip.Name = "ArtBlip";
            this.ArtBlip.Size = new System.Drawing.Size(234, 33);
            this.ArtBlip.TabIndex = 6;
            this.ArtBlip.Text = "ArtBlip Employee";
            this.ArtBlip.Click += new System.EventHandler(this.ArtBlip_Click);
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.BackColor = System.Drawing.Color.Transparent;
            this.employeeID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeID.ForeColor = System.Drawing.Color.DarkRed;
            this.employeeID.Location = new System.Drawing.Point(-2, 38);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(97, 19);
            this.employeeID.TabIndex = 23;
            this.employeeID.Text = "Employee ID";
            this.employeeID.Click += new System.EventHandler(this.ArtworkID_Click);
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.BackColor = System.Drawing.Color.Transparent;
            this.employeeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.ForeColor = System.Drawing.Color.DarkRed;
            this.employeeName.Location = new System.Drawing.Point(11, 74);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(84, 19);
            this.employeeName.TabIndex = 24;
            this.employeeName.Text = "First Name";
            // 
            // employeePosition
            // 
            this.employeePosition.AutoSize = true;
            this.employeePosition.BackColor = System.Drawing.Color.Transparent;
            this.employeePosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePosition.ForeColor = System.Drawing.Color.DarkRed;
            this.employeePosition.Location = new System.Drawing.Point(46, 186);
            this.employeePosition.Name = "employeePosition";
            this.employeePosition.Size = new System.Drawing.Size(49, 19);
            this.employeePosition.TabIndex = 25;
            this.employeePosition.Text = "CNIC";
            // 
            // textEmployeeID
            // 
            this.textEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmployeeID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.textEmployeeID.Location = new System.Drawing.Point(125, 40);
            this.textEmployeeID.Name = "textEmployeeID";
            this.textEmployeeID.Size = new System.Drawing.Size(131, 20);
            this.textEmployeeID.TabIndex = 28;
            this.textEmployeeID.Text = "ArtworkID";
            // 
            // textFirstName
            // 
            this.textFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFirstName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.ForeColor = System.Drawing.Color.Gray;
            this.textFirstName.Location = new System.Drawing.Point(125, 76);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(131, 20);
            this.textFirstName.TabIndex = 29;
            this.textFirstName.Text = "fisrt name";
            // 
            // textCNIC
            // 
            this.textCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCNIC.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCNIC.ForeColor = System.Drawing.Color.Gray;
            this.textCNIC.Location = new System.Drawing.Point(125, 185);
            this.textCNIC.Name = "textCNIC";
            this.textCNIC.Size = new System.Drawing.Size(131, 20);
            this.textCNIC.TabIndex = 30;
            this.textCNIC.Text = "cnic";
            // 
            // CMDSave
            // 
            this.CMDSave.BackColor = System.Drawing.Color.SaddleBrown;
            this.CMDSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDSave.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDSave.Location = new System.Drawing.Point(127, 396);
            this.CMDSave.Name = "CMDSave";
            this.CMDSave.Size = new System.Drawing.Size(88, 38);
            this.CMDSave.TabIndex = 31;
            this.CMDSave.Tag = "";
            this.CMDSave.Text = "Save";
            this.CMDSave.UseVisualStyleBackColor = false;
            this.CMDSave.Click += new System.EventHandler(this.CMDSave_Click);
            // 
            // CMDBack
            // 
            this.CMDBack.BackColor = System.Drawing.Color.SaddleBrown;
            this.CMDBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDBack.ForeColor = System.Drawing.SystemColors.Window;
            this.CMDBack.Location = new System.Drawing.Point(25, 406);
            this.CMDBack.Name = "CMDBack";
            this.CMDBack.Size = new System.Drawing.Size(70, 28);
            this.CMDBack.TabIndex = 32;
            this.CMDBack.Tag = "";
            this.CMDBack.Text = "Back";
            this.CMDBack.UseVisualStyleBackColor = false;
            this.CMDBack.Click += new System.EventHandler(this.CMDBack_Click);
            // 
            // textContactNo
            // 
            this.textContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContactNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContactNo.ForeColor = System.Drawing.Color.Gray;
            this.textContactNo.Location = new System.Drawing.Point(127, 253);
            this.textContactNo.Name = "textContactNo";
            this.textContactNo.Size = new System.Drawing.Size(131, 20);
            this.textContactNo.TabIndex = 34;
            this.textContactNo.Text = "ContactNo";
            this.textContactNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contactNo
            // 
            this.contactNo.AutoSize = true;
            this.contactNo.BackColor = System.Drawing.Color.Transparent;
            this.contactNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNo.ForeColor = System.Drawing.Color.DarkRed;
            this.contactNo.Location = new System.Drawing.Point(10, 254);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(85, 19);
            this.contactNo.TabIndex = 33;
            this.contactNo.Text = "Contact No";
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.Gray;
            this.textEmail.Location = new System.Drawing.Point(125, 221);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(131, 20);
            this.textEmail.TabIndex = 36;
            this.textEmail.Text = "email";
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Maroon;
            this.email.Location = new System.Drawing.Point(48, 222);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(47, 19);
            this.email.TabIndex = 35;
            this.email.Text = "Email";
            // 
            // textSecondName
            // 
            this.textSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSecondName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecondName.ForeColor = System.Drawing.Color.Gray;
            this.textSecondName.Location = new System.Drawing.Point(125, 107);
            this.textSecondName.Name = "textSecondName";
            this.textSecondName.Size = new System.Drawing.Size(131, 20);
            this.textSecondName.TabIndex = 38;
            this.textSecondName.Text = "second name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Last Name";
            // 
            // textAddress
            // 
            this.textAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAddress.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.ForeColor = System.Drawing.Color.Gray;
            this.textAddress.Location = new System.Drawing.Point(125, 138);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(131, 20);
            this.textAddress.TabIndex = 40;
            this.textAddress.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(31, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Address";
            // 
            // textSalary
            // 
            this.textSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSalary.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalary.ForeColor = System.Drawing.Color.Gray;
            this.textSalary.Location = new System.Drawing.Point(125, 290);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(131, 20);
            this.textSalary.TabIndex = 46;
            this.textSalary.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(43, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Salary";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 330);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 48;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.Color.Transparent;
            this.DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.DarkRed;
            this.DOB.Location = new System.Drawing.Point(26, 330);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(74, 19);
            this.DOB.TabIndex = 47;
            this.DOB.Text = "Join Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(123, 368);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker2.TabIndex = 50;
            this.dateTimePicker2.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(23, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "End Date";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(288, 334);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(78, 20);
            this.txtSearch.TabIndex = 55;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(390, 334);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 54;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CMDDelete
            // 
            this.CMDDelete.Location = new System.Drawing.Point(596, 334);
            this.CMDDelete.Name = "CMDDelete";
            this.CMDDelete.Size = new System.Drawing.Size(75, 23);
            this.CMDDelete.TabIndex = 53;
            this.CMDDelete.Text = "Delete";
            this.CMDDelete.UseVisualStyleBackColor = true;
            this.CMDDelete.Click += new System.EventHandler(this.CMDDelete_Click);
            // 
            // CMDUpdate
            // 
            this.CMDUpdate.Location = new System.Drawing.Point(493, 334);
            this.CMDUpdate.Name = "CMDUpdate";
            this.CMDUpdate.Size = new System.Drawing.Size(75, 23);
            this.CMDUpdate.TabIndex = 52;
            this.CMDUpdate.Text = "Update";
            this.CMDUpdate.UseVisualStyleBackColor = true;
            this.CMDUpdate.Click += new System.EventHandler(this.CMDUpdate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eID,
            this.name2,
            this.name1,
            this.add,
            this.CNIC,
            this.Eemail,
            this.Contact,
            this.Salary,
            this.Join,
            this.end});
            this.dataGridView2.Location = new System.Drawing.Point(288, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(754, 272);
            this.dataGridView2.TabIndex = 51;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // eID
            // 
            this.eID.HeaderText = "ID";
            this.eID.Name = "eID";
            this.eID.Width = 30;
            // 
            // name2
            // 
            this.name2.HeaderText = "sName";
            this.name2.Name = "name2";
            this.name2.Width = 50;
            // 
            // name1
            // 
            this.name1.HeaderText = "fName";
            this.name1.Name = "name1";
            this.name1.Width = 50;
            // 
            // add
            // 
            this.add.HeaderText = "Address";
            this.add.Name = "add";
            // 
            // CNIC
            // 
            this.CNIC.HeaderText = "CNIC";
            this.CNIC.Name = "CNIC";
            this.CNIC.Width = 70;
            // 
            // Eemail
            // 
            this.Eemail.HeaderText = "Email";
            this.Eemail.Name = "Eemail";
            // 
            // Contact
            // 
            this.Contact.HeaderText = "ContactNo";
            this.Contact.Name = "Contact";
            this.Contact.Width = 70;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.Width = 70;
            // 
            // Join
            // 
            this.Join.HeaderText = "Join";
            this.Join.Name = "Join";
            // 
            // end
            // 
            this.end.HeaderText = "leave";
            this.end.Name = "end";
            // 
            // DeleteArtwork
            // 
            this.AccessibleDescription = "Employees";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.del;
            this.ClientSize = new System.Drawing.Size(1054, 470);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.CMDDelete);
            this.Controls.Add(this.CMDUpdate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSecondName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textContactNo);
            this.Controls.Add(this.contactNo);
            this.Controls.Add(this.CMDBack);
            this.Controls.Add(this.CMDSave);
            this.Controls.Add(this.textCNIC);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textEmployeeID);
            this.Controls.Add(this.employeePosition);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.ArtBlip);
            this.Name = "DeleteArtwork";
            this.Text = "DeleteArtwork";
            this.Load += new System.EventHandler(this.DeleteArtwork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArtBlip;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label employeePosition;
        private System.Windows.Forms.TextBox textEmployeeID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textCNIC;
        private System.Windows.Forms.Button CMDSave;
        private System.Windows.Forms.Button CMDBack;
        private System.Windows.Forms.TextBox textContactNo;
        private System.Windows.Forms.Label contactNo;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button CMDDelete;
        private System.Windows.Forms.Button CMDUpdate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Join;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
    }
}