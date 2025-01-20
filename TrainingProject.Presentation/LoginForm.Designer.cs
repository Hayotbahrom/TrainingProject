namespace TrainingProject.Presentation
{
    partial class LoginForm
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
            tabControl1 = new TabControl();
            tabLogin = new TabPage();
            lblLoginMessage = new Label();
            textPassword = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textUsername = new TextBox();
            label1 = new Label();
            tabRegister = new TabPage();
            btnRegister = new Button();
            textConfirmPassword = new TextBox();
            label5 = new Label();
            textRegPassword = new TextBox();
            label3 = new Label();
            textRegUsername = new TextBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabLogin.SuspendLayout();
            tabRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.CausesValidation = false;
            tabControl1.Controls.Add(tabLogin);
            tabControl1.Controls.Add(tabRegister);
            tabControl1.Location = new Point(31, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(734, 412);
            tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            tabLogin.BackColor = Color.LightGray;
            tabLogin.Controls.Add(lblLoginMessage);
            tabLogin.Controls.Add(textPassword);
            tabLogin.Controls.Add(label2);
            tabLogin.Controls.Add(button1);
            tabLogin.Controls.Add(textUsername);
            tabLogin.Controls.Add(label1);
            tabLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabLogin.Location = new Point(4, 29);
            tabLogin.Name = "tabLogin";
            tabLogin.Padding = new Padding(3);
            tabLogin.Size = new Size(726, 379);
            tabLogin.TabIndex = 0;
            tabLogin.Text = "Login";
            // 
            // lblLoginMessage
            // 
            lblLoginMessage.AutoSize = true;
            lblLoginMessage.Font = new Font("Stencil", 12F);
            lblLoginMessage.Location = new Point(278, 29);
            lblLoginMessage.Name = "lblLoginMessage";
            lblLoginMessage.Size = new Size(0, 24);
            lblLoginMessage.TabIndex = 5;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(278, 166);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(284, 34);
            textPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F);
            label2.Location = new Point(103, 169);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(278, 236);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(278, 104);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(284, 34);
            textUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F);
            label1.Location = new Point(98, 107);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tabRegister
            // 
            tabRegister.BackColor = Color.LightGray;
            tabRegister.Controls.Add(btnRegister);
            tabRegister.Controls.Add(textConfirmPassword);
            tabRegister.Controls.Add(label5);
            tabRegister.Controls.Add(textRegPassword);
            tabRegister.Controls.Add(label3);
            tabRegister.Controls.Add(textRegUsername);
            tabRegister.Controls.Add(label4);
            tabRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabRegister.Location = new Point(4, 29);
            tabRegister.Name = "tabRegister";
            tabRegister.Padding = new Padding(3);
            tabRegister.Size = new Size(726, 379);
            tabRegister.TabIndex = 1;
            tabRegister.Text = "Register";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveCaption;
            btnRegister.Location = new Point(259, 228);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(153, 49);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.Location = new Point(259, 165);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.Size = new Size(284, 34);
            textConfirmPassword.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 12F);
            label5.Location = new Point(29, 173);
            label5.Name = "label5";
            label5.Size = new Size(205, 24);
            label5.TabIndex = 9;
            label5.Text = "Confirm Password";
            // 
            // textRegPassword
            // 
            textRegPassword.Location = new Point(259, 112);
            textRegPassword.Name = "textRegPassword";
            textRegPassword.Size = new Size(284, 34);
            textRegPassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F);
            label3.Location = new Point(84, 115);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // textRegUsername
            // 
            textRegUsername.Location = new Point(259, 50);
            textRegUsername.Name = "textRegUsername";
            textRegUsername.Size = new Size(284, 34);
            textRegUsername.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F);
            label4.Location = new Point(79, 53);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            tabControl1.ResumeLayout(false);
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            tabRegister.ResumeLayout(false);
            tabRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabLogin;
        private TabPage tabRegister;
        private TextBox textPassword;
        private Label label2;
        private Button button1;
        private TextBox textUsername;
        private Label label1;
        private Button btnRegister;
        private TextBox textConfirmPassword;
        private Label label5;
        private TextBox textRegPassword;
        private Label label3;
        private TextBox textRegUsername;
        private Label label4;
        private Label lblLoginMessage;
    }
}