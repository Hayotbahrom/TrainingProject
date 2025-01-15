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
        Guid modelId;
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
            try
            {
                if (btnSave.Text == "Update")
                {
                    ContactForUpdateDto contact = new ContactForUpdateDto()
                    {
                        FirstName = textFirstname.Text,
                        LastName = textLastname.Text,
                        Email = textEmail.Text,
                        PhoneNumber = textPhoneNumber.Text,
                        Position = textPosition.Text,
                        CompanyId = Guid.Parse(textCompany.Text),
                        Notes = textNote.Text
                    };
                    bool result = await contactFormService.UpdateAsync(modelId, contact);
                    if (result)
                    {
                        MessageBox.Show("Contact successfuly updated!");
                        Clear();
                        PopulateDataGridView();
                    }
                    else
                        MessageBox.Show("update Failed");
                }
                else
                {
                    var contact = new ContactForCreationDto()
                    {
                        FirstName = textFirstname.Text,
                        LastName = textLastname.Text,
                        Email = textEmail.Text,
                        PhoneNumber = textPhoneNumber.Text,
                        Position = textPosition.Text,
                        CompanyId = Guid.Parse(textCompany.Text),
                        Notes = textNote.Text
                    };
                    bool result = await contactFormService.AddAsync(contact);
                    if (result)
                    {
                        MessageBox.Show("Contact successfuly inserted!");
                        Clear();
                        PopulateDataGridView();
                    }
                    else
                        MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await contactFormService.DeleteAsync(modelId);
                if (result)
                {
                    MessageBox.Show("Successfully deleted..");
                    Clear();
                    PopulateDataGridView();
                }
                else MessageBox.Show("Failed, maybe you didnt select any contact");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
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
            btnSave.Text = "Save";
        }
        async void PopulateDataGridView()
        {
            dataGridView1.DataSource = (await contactFormService.GetAllAsync()).ToList();
        }

        private async void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                modelId = Guid.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                var model = await contactFormService.GetByIdAsync(modelId);

                textFirstname.Text = model.FirstName;
                textLastname.Text = model.LastName;
                textEmail.Text = model.Email;
                textPhoneNumber.Text = model.PhoneNumber;
                textCompany.Text = model.CompanyId.ToString();
                textNote.Text = model.Notes;
                textPosition.Text = model.Position;

                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }
    }
}
