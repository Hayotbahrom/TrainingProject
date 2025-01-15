namespace TrainingProject.Presentation
{
    partial class CompanyForm
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
            btnLogout = new Button();
            btnMain = new Button();
            textCity = new TextBox();
            label7 = new Label();
            textStreet = new TextBox();
            label6 = new Label();
            textPostalcode = new TextBox();
            label5 = new Label();
            textEmail = new TextBox();
            label4 = new Label();
            textPhoneNumber = new TextBox();
            label3 = new Label();
            textWebsite = new TextBox();
            label2 = new Label();
            textFirstname = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnSave = new Button();
            label8 = new Label();
            label9 = new Label();
            textCountry = new TextBox();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Website = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(913, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 45);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.ForestGreen;
            btnMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMain.ForeColor = SystemColors.ButtonFace;
            btnMain.Location = new Point(793, 12);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(114, 45);
            btnMain.TabIndex = 5;
            btnMain.Text = "Dashbord";
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += button1_Click;
            // 
            // textCity
            // 
            textCity.Location = new Point(120, 271);
            textCity.Name = "textCity";
            textCity.Size = new Size(125, 27);
            textCity.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 271);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 40;
            label7.Text = "City";
            // 
            // textStreet
            // 
            textStreet.Location = new Point(120, 238);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(125, 27);
            textStreet.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 238);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 38;
            label6.Text = "Street";
            // 
            // textPostalcode
            // 
            textPostalcode.Location = new Point(120, 205);
            textPostalcode.Name = "textPostalcode";
            textPostalcode.Size = new Size(125, 27);
            textPostalcode.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 208);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 36;
            label5.Text = "Postal code";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(120, 172);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 172);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 34;
            label4.Text = "Email";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(120, 139);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(125, 27);
            textPhoneNumber.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-6, 139);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 32;
            label3.Text = "Phone Number";
            // 
            // textWebsite
            // 
            textWebsite.Location = new Point(120, 106);
            textWebsite.Name = "textWebsite";
            textWebsite.Size = new Size(125, 27);
            textWebsite.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 106);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 30;
            label2.Text = "Website";
            // 
            // textFirstname
            // 
            textFirstname.Location = new Point(120, 73);
            textFirstname.Name = "textFirstname";
            textFirstname.Size = new Size(125, 27);
            textFirstname.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Email, Website, PhoneNumber, Street, City, Country });
            dataGridView1.Location = new Point(285, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(742, 375);
            dataGridView1.TabIndex = 27;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(151, 344);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(51, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(285, 16);
            label8.Name = "label8";
            label8.Size = new Size(151, 41);
            label8.TabIndex = 42;
            label8.Text = "Company";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 302);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 43;
            label9.Text = "Country";
            // 
            // textCountry
            // 
            textCountry.Location = new Point(120, 304);
            textCountry.Name = "textCountry";
            textCountry.Size = new Size(125, 27);
            textCountry.TabIndex = 44;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Website
            // 
            Website.DataPropertyName = "Website";
            Website.HeaderText = "Website";
            Website.MinimumWidth = 6;
            Website.Name = "Website";
            Website.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 125;
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.HeaderText = "Street";
            Street.MinimumWidth = 6;
            Street.Name = "Street";
            Street.Width = 125;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // Country
            // 
            Country.DataPropertyName = "Country";
            Country.HeaderText = "Country";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            Country.Width = 125;
            // 
            // CompanyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 474);
            Controls.Add(textCountry);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textCity);
            Controls.Add(label7);
            Controls.Add(textStreet);
            Controls.Add(label6);
            Controls.Add(textPostalcode);
            Controls.Add(label5);
            Controls.Add(textEmail);
            Controls.Add(label4);
            Controls.Add(textPhoneNumber);
            Controls.Add(label3);
            Controls.Add(textWebsite);
            Controls.Add(label2);
            Controls.Add(textFirstname);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnMain);
            Controls.Add(btnLogout);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompanyForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnMain;
        private TextBox textCity;
        private Label label7;
        private TextBox textStreet;
        private Label label6;
        private TextBox textPostalcode;
        private Label label5;
        private TextBox textEmail;
        private Label label4;
        private TextBox textPhoneNumber;
        private Label label3;
        private TextBox textWebsite;
        private Label label2;
        private TextBox textFirstname;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnSave;
        private Label label8;
        private Label label9;
        private TextBox textCountry;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Website;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Country;
    }
}