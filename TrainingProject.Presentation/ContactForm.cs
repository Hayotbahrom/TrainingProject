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
using TrainingProject.Shared.DTOs.Contacts;

namespace TrainingProject.Presentation
{
    public partial class ContactForm : Form
    {
        private ContactFormService contactFormService;
        public ContactForm()
        {
            InitializeComponent();
            contactFormService = new ContactFormService(new HttpClient());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ContactForCreationDto contact = new ContactForCreationDto()
            {
                FirstName = textFirstname.Text,
                LastName = textLastname.Text,
                Email = textEmail.Text,
                PhoneNumber = textPhoneNumber.Text,
                Position = textPosition.Text,
                CompanyId = Guid.Parse(textCompany.Text),
                Notes = textNote.Text
            };
            try
            {
                bool result = await contactFormService.AddAsync(contact);
                if (result)
                {
                    MessageBox.Show("Contact successfuly inserted!");
                    Clear();
                    PopulateDataGridView();
                }
                else 
                    MessageBox.Show("Failed, Contract is already exist.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Contact(object sender, EventArgs e)
        {

        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }
        private void Clear()
        {
            var textBoxes = new List<TextBox> { textFirstname, textLastname, textEmail, textPhoneNumber, textPosition, textCompany, textNote };
            foreach (var textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }
        }
        async void PopulateDataGridView()
        {
            dataGridView1.DataSource = (await contactFormService.GetAllAsync()).ToList();
        }
    }
}
