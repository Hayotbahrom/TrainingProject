namespace TrainingProject.Presentation
{
    partial class ContactForm
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
            btnSave = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textFirstname = new TextBox();
            textLastname = new TextBox();
            label2 = new Label();
            textPhoneNumber = new TextBox();
            label3 = new Label();
            textEmail = new TextBox();
            label4 = new Label();
            textPosition = new TextBox();
            label5 = new Label();
            textCompany = new TextBox();
            label6 = new Label();
            textNote = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Firstname = new DataGridViewTextBoxColumn();
            Lastname = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            CompanyId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(927, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 45);
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
            btnMain.Location = new Point(807, 12);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(114, 45);
            btnMain.TabIndex = 6;
            btnMain.Text = "Dashbord";
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMain_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(59, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(159, 334);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Firstname, Lastname, PhoneNumber, Note, Email, Position, CompanyId });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(279, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(756, 375);
            dataGridView1.TabIndex = 10;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 63);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 11;
            label1.Text = "Firstname";
            // 
            // textFirstname
            // 
            textFirstname.Location = new Point(128, 63);
            textFirstname.Name = "textFirstname";
            textFirstname.Size = new Size(125, 27);
            textFirstname.TabIndex = 12;
            // 
            // textLastname
            // 
            textLastname.Location = new Point(128, 96);
            textLastname.Name = "textLastname";
            textLastname.Size = new Size(125, 27);
            textLastname.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 96);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 13;
            label2.Text = "Lastname";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(128, 129);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(125, 27);
            textPhoneNumber.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 129);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 15;
            label3.Text = "Phone Number";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(128, 162);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 162);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 17;
            label4.Text = "Email";
            // 
            // textPosition
            // 
            textPosition.Location = new Point(128, 195);
            textPosition.Name = "textPosition";
            textPosition.Size = new Size(125, 27);
            textPosition.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 195);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 19;
            label5.Text = "Position";
            // 
            // textCompany
            // 
            textCompany.Location = new Point(128, 228);
            textCompany.Name = "textCompany";
            textCompany.Size = new Size(125, 27);
            textCompany.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 228);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 21;
            label6.Text = "Company ID";
            // 
            // textNote
            // 
            textNote.Location = new Point(128, 261);
            textNote.Name = "textNote";
            textNote.Size = new Size(125, 27);
            textNote.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 261);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 23;
            label7.Text = "Note";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(279, 12);
            label8.Name = "label8";
            label8.Size = new Size(130, 38);
            label8.TabIndex = 45;
            label8.Text = "Contacts";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Firstname
            // 
            Firstname.DataPropertyName = "FirstName";
            Firstname.HeaderText = "Firstname";
            Firstname.MinimumWidth = 6;
            Firstname.Name = "Firstname";
            Firstname.ReadOnly = true;
            Firstname.Width = 125;
            // 
            // Lastname
            // 
            Lastname.DataPropertyName = "LastName";
            Lastname.HeaderText = "Lastname";
            Lastname.MinimumWidth = 6;
            Lastname.Name = "Lastname";
            Lastname.ReadOnly = true;
            Lastname.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 125;
            // 
            // Note
            // 
            Note.DataPropertyName = "Notes";
            Note.HeaderText = "Note";
            Note.MinimumWidth = 6;
            Note.Name = "Note";
            Note.ReadOnly = true;
            Note.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Position
            // 
            Position.DataPropertyName = "Position";
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 125;
            // 
            // CompanyId
            // 
            CompanyId.DataPropertyName = "CompanyId";
            CompanyId.HeaderText = "CompanyId";
            CompanyId.MinimumWidth = 6;
            CompanyId.Name = "CompanyId";
            CompanyId.ReadOnly = true;
            CompanyId.Width = 125;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 450);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(textNote);
            Controls.Add(label7);
            Controls.Add(textCompany);
            Controls.Add(label6);
            Controls.Add(textPosition);
            Controls.Add(label5);
            Controls.Add(textEmail);
            Controls.Add(label4);
            Controls.Add(textPhoneNumber);
            Controls.Add(label3);
            Controls.Add(textLastname);
            Controls.Add(label2);
            Controls.Add(textFirstname);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnMain);
            Controls.Add(btnLogout);
            Name = "ContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactForm";
            Load += ContactForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnMain;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textFirstname;
        private TextBox textLastname;
        private Label label2;
        private TextBox textPhoneNumber;
        private Label label3;
        private TextBox textEmail;
        private Label label4;
        private TextBox textPosition;
        private Label label5;
        private TextBox textCompany;
        private Label label6;
        private TextBox textNote;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Note;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn CompanyId;
    }
}