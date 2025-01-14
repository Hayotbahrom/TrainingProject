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
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(844, 12);
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
            btnMain.Location = new Point(724, 12);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(114, 45);
            btnMain.TabIndex = 5;
            btnMain.Text = "Dashbord";
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += button1_Click;
            // 
            // CompanyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 474);
            Controls.Add(btnMain);
            Controls.Add(btnLogout);
            Name = "CompanyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompanyForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button btnMain;
    }
}