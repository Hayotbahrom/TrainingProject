using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingProject.Proxy.Services;
using TrainingProject.Shared.DTOs.Users;

namespace TrainingProject.Presentation
{
    public partial class LoginForm : Form
    {
        private LoginFormService loginFormService;
        public LoginForm()
        {
            InitializeComponent();
            loginFormService = new LoginFormService(new HttpClient());
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            var loginModel = new UserForCreationDto()
            {
                Username = textUsername.Text,
                Password = textPassword.Text,
            };
            try
            {
                var tokenResponse = await loginFormService.LoginAsync(loginModel);
                if (tokenResponse != null)
                {
                    this.Hide();  // Hide current form
                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    MessageBox.Show($"Login successful! Token: {tokenResponse.Token}");
                }
                else
                {
                    MessageBox.Show("Login failed! No valid token was returned.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed! An error occured: {ex.Message}");
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (textRegPassword.Text == textConfirmPassword.Text)
            {
                bool isRegistered = await loginFormService.RegisterAsync(textRegUsername.Text, textRegPassword.Text);
                if (isRegistered)
                    MessageBox.Show($"{textRegUsername.Text} successfully registered!");
                else
                    MessageBox.Show("Registration failed! Please try again.");
            }
            else
            {
                MessageBox.Show("Password and Confirmed password are not match");
            }
        }
    }
}
