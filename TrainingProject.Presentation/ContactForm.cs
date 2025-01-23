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
using TrainingProject.Proxy.ViewModels;
using TrainingProject.Shared.DTOs.Contacts;

namespace TrainingProject.Presentation
{

     
    public partial class ContactForm : Form
    {
        private Guid modelId;
        private ContactViewModel _contactViewModel;
        private BindingSource _bindingSource;
        public ContactForm()
        {
            InitializeComponent();
            _contactViewModel = new ContactViewModel();
            _bindingSource = new BindingSource();

            BindControls();
            BindDataGridView();
            PopulateDataGridView();
        }
        private void BindControls()
        {
            textFirstname.DataBindings.Add("Text", _contactViewModel, nameof(_contactViewModel.FirstName), false,DataSourceUpdateMode.OnPropertyChanged);
            textLastname.DataBindings.Add("Text", _contactViewModel, nameof(_contactViewModel.LastName), false,DataSourceUpdateMode.OnPropertyChanged);
            textEmail.DataBindings.Add("Text", _contactViewModel, nameof(_contactViewModel.Email), false,DataSourceUpdateMode.OnPropertyChanged);
            textPosition.DataBindings.Add("Text", _contactViewModel, nameof(_contactViewModel.Position), false,DataSourceUpdateMode.OnPropertyChanged);
            textPhoneNumber.DataBindings.Add("Text", _contactViewModel, nameof(_contactViewModel.PhoneNumber), false,DataSourceUpdateMode.OnPropertyChanged);
            textNote.DataBindings.Add("Text", _contactViewModel, nameof(_contactViewModel.Notes), false,DataSourceUpdateMode.OnPropertyChanged);
            textCompany.DataBindings.Add("Text", _contactViewModel, nameof(_contactViewModel.CompanyId), false, DataSourceUpdateMode.OnPropertyChanged);
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
            if (btnSave.Text == "Update")
            {
                var result = await _contactViewModel.UpdateContactAsync(modelId);
            }
            else
            {
                var result = await _contactViewModel.AddContactAsync();
            }
            MessageBox.Show(_contactViewModel.StatusMessage);
            Clear();
            PopulateDataGridView();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await _contactViewModel.DeleteContactAsync(modelId);
            MessageBox.Show(_contactViewModel?.StatusMessage);
            Clear();
            PopulateDataGridView();
        }

        private void Contact(object sender, EventArgs e)
        {
           
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            Clear();
            BindDataGridView();
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
            //var contacts = _contactViewModel.Contacts;
            await _contactViewModel.LoadAllContactsAsync();
            _bindingSource.ResetBindings(false);
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            _bindingSource.DataSource = _contactViewModel.Contacts;
            dataGridView1.DataSource = _bindingSource;
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                modelId = Guid.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                var contact = _contactViewModel.Contacts.First(c => c.Id == modelId);

                _contactViewModel.FirstName = contact.FirstName;
                _contactViewModel.LastName = contact.LastName;
                _contactViewModel.Email = contact.Email;
                _contactViewModel.PhoneNumber = contact.PhoneNumber;
                _contactViewModel.CompanyId = contact.CompanyId;
                _contactViewModel.Notes = contact.Notes;
                _contactViewModel.Position = contact.Position;

                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }


    }
}
