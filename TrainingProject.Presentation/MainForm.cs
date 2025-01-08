using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingProject.UseCase.DTOs.Companies;

namespace TrainingProject.Presentation
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7143/api/") };
        CompanyForCreationDto dto = new CompanyForCreationDto();
        public MainForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            dto.Name = txtName.Text;
            dto.Email = textEmail.Text;
            dto.Street = textStreet.Text;
            dto.City = textCity.Text;
            dto.Country = textCountry.Text;
            dto.Website = textWebsite.Text;
            dto.PostalCode = textPostalcode.Text;
            dto.PhoneNumber = textPhoneNumber.Text;
           
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Companies", dto);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Company added.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void Clear()
        {
            txtName.Text = textCity.Text = textCountry.Text = textEmail.Text = textPhoneNumber.Text = textPostalcode.Text = textStreet.Text = textWebsite.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }
    }
}
