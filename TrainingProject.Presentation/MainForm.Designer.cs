namespace TrainingProject.Presentation
{
    partial class MainForm
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
            txtName = new TextBox();
            textPostalcode = new TextBox();
            textStreet = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textCity = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textCountry = new TextBox();
            label6 = new Label();
            textPhoneNumber = new TextBox();
            label7 = new Label();
            textEmail = new TextBox();
            label8 = new Label();
            textWebsite = new TextBox();
            label9 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Website = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 27);
            txtName.TabIndex = 0;
            // 
            // textPostalcode
            // 
            textPostalcode.Location = new Point(166, 139);
            textPostalcode.Name = "textPostalcode";
            textPostalcode.Size = new Size(177, 27);
            textPostalcode.TabIndex = 1;
            // 
            // textStreet
            // 
            textStreet.Location = new Point(166, 106);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(177, 27);
            textStreet.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Email, Website, Street, City, Country, PostalCode, PhoneNumber });
            dataGridView1.Location = new Point(373, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 322);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(81, 76);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textCity
            // 
            textCity.Location = new Point(166, 172);
            textCity.Name = "textCity";
            textCity.Size = new Size(177, 27);
            textCity.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(58, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(153, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 41);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(249, 354);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 41);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(82, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 9;
            label2.Text = "Street";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(47, 142);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 10;
            label3.Text = "PostalCode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(96, 175);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 11;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(70, 208);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 13;
            label5.Text = "Country";
            // 
            // textCountry
            // 
            textCountry.Location = new Point(166, 205);
            textCountry.Name = "textCountry";
            textCountry.Size = new Size(177, 27);
            textCountry.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(26, 241);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 15;
            label6.Text = "PhoneNumber";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(166, 238);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(177, 27);
            textPhoneNumber.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(84, 274);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 17;
            label7.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(166, 271);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(177, 27);
            textEmail.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(68, 307);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 19;
            label8.Text = "Website";
            // 
            // textWebsite
            // 
            textWebsite.Location = new Point(166, 304);
            textWebsite.Name = "textWebsite";
            textWebsite.Size = new Size(177, 27);
            textWebsite.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(294, 21);
            label9.Name = "label9";
            label9.Size = new Size(142, 33);
            label9.TabIndex = 20;
            label9.Text = "COMPANY";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Website
            // 
            Website.HeaderText = "Website";
            Website.MinimumWidth = 6;
            Website.Name = "Website";
            Website.Width = 125;
            // 
            // Street
            // 
            Street.HeaderText = "Street";
            Street.MinimumWidth = 6;
            Street.Name = "Street";
            Street.Width = 125;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            Country.Width = 125;
            // 
            // PostalCode
            // 
            PostalCode.HeaderText = "PostalCode";
            PostalCode.MinimumWidth = 6;
            PostalCode.Name = "PostalCode";
            PostalCode.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Column1";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1186, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textWebsite);
            Controls.Add(label7);
            Controls.Add(textEmail);
            Controls.Add(label6);
            Controls.Add(textPhoneNumber);
            Controls.Add(label5);
            Controls.Add(textCountry);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(textCity);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textStreet);
            Controls.Add(textPostalcode);
            Controls.Add(txtName);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox textPostalcode;
        private TextBox textStreet;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textCity;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textCountry;
        private Label label6;
        private TextBox textPhoneNumber;
        private Label label7;
        private TextBox textEmail;
        private Label label8;
        private TextBox textWebsite;
        private Label label9;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Website;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridViewTextBoxColumn PhoneNumber;
    }
}