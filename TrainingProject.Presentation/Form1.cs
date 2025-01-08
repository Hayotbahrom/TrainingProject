using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingProject.Presentation
{

    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var loginData = new
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                //string url = "http://localhost:5141/api/Auth/login";
                string url = "https://localhost:7143/api/Auth/login"; // Correct the port if needed
                var jsonContent = new StringContent(JsonSerializer.Serialize(loginData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(responseContent);

                    this.Hide();  // Hide current form
                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    MessageBox.Show($"Login successful! Token: {tokenResponse.Token}");
                }
                else
                {
                    MessageBox.Show($"Login failed! Status Code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var registerData = new
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                string url = "https://localhost:7143/api/Users"; // Correct the port if needed
                var jsonContent = new StringContent(JsonSerializer.Serialize(registerData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"{registerData.Username} successfully registered");
                }
                else
                {
                    MessageBox.Show($"Login failed! Status Code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
    public class TokenResponse
    {
        public string Token { get; set; }
    }
}
