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
            label1 = new Label();
            btnContact = new Button();
            btnCompany = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 49);
            label1.Margin = new Padding(3, 1, 3, 1);
            label1.Name = "label1";
            label1.Size = new Size(191, 35);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // btnContact
            // 
            btnContact.BackColor = SystemColors.GradientActiveCaption;
            btnContact.Location = new Point(161, 213);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(156, 66);
            btnContact.TabIndex = 1;
            btnContact.Text = "Contacts";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
            // 
            // btnCompany
            // 
            btnCompany.BackColor = SystemColors.GradientActiveCaption;
            btnCompany.Location = new Point(469, 213);
            btnCompany.Name = "btnCompany";
            btnCompany.Size = new Size(156, 66);
            btnCompany.TabIndex = 2;
            btnCompany.Text = "Companies";
            btnCompany.UseVisualStyleBackColor = false;
            btnCompany.Click += btnCompany_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(656, 33);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 51);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnCompany);
            Controls.Add(btnContact);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnContact;
        private Button btnCompany;
        private Button btnLogout;
    }
}