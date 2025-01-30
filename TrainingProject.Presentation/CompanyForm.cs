using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingProject.Proxy.ViewModels;

namespace TrainingProject.Presentation
{
    public partial class CompanyForm : Form
    {
        private readonly CompanyViewModel _companyViewModel;
        private Guid id;
        private BindingSource _bindingSource;
        public CompanyForm()
        {
            InitializeComponent();
            _companyViewModel = new CompanyViewModel();
            _bindingSource = new BindingSource();

            BindControls();
            PopulateDataGridView();
        }
        private async void PopulateDataGridView()
        {
            await _companyViewModel.LoadAllCompaniesAsync();
            _bindingSource.ResetBindings(false);
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            _bindingSource.DataSource = _companyViewModel.Companies;
            dataGridView1.DataSource = _bindingSource;
        }
        private void Clear()
        {
            var TextBoxes = new List<TextBox>() { textName, textCity, textStreet, textCountry, textPhoneNumber, textEmail, textPostalcode, textWebsite };
            foreach (var textBox in TextBoxes)
            {
                textBox.Text = string.Empty;
            }
            btnSave.Text = "Save";
        }
        private void BindControls()
        {
            textName.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.Name), false, DataSourceUpdateMode.OnPropertyChanged);
            textCity.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.City), false, DataSourceUpdateMode.OnPropertyChanged);
            textStreet.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.Street), false, DataSourceUpdateMode.OnPropertyChanged);
            textCountry.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.Country), false, DataSourceUpdateMode.OnPropertyChanged);
            textEmail.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.Email), false, DataSourceUpdateMode.OnPropertyChanged);
            textPhoneNumber.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.PhoneNumber), false, DataSourceUpdateMode.OnPropertyChanged);
            textPostalcode.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.PostalCode), false, DataSourceUpdateMode.OnPropertyChanged);
            textWebsite.DataBindings.Add("Text", _companyViewModel, nameof(_companyViewModel.Website), false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Update")
            {
                var result = await _companyViewModel.UpdateCompanyAsync(id);
            }
            else
            {
                var result = await _companyViewModel.AddCompanyAsync();
            }
            MessageBox.Show(_companyViewModel.StatusMessage);
            Clear();
            PopulateDataGridView();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await _companyViewModel.DeleteCompanyAsync(id);
            MessageBox.Show(_companyViewModel.StatusMessage);
            Clear();
            PopulateDataGridView();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            else
            {
                try
                {
                    id = Guid.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                    var company = _companyViewModel.Companies.First(c => c.Id == id);
                    _companyViewModel.Name = company.Name;
                    _companyViewModel.Street= company.Street;
                    _companyViewModel.City= company.City;
                    _companyViewModel.Country= company.Country;
                    _companyViewModel.Website = company.Website;
                    _companyViewModel.Email = company.Email;
                    _companyViewModel.PhoneNumber = company.PhoneNumber;
                    _companyViewModel.PostalCode = company.PostalCode;

                    btnSave.Text = "Update";
                }
                catch(Exception ex)     
                {
                    MessageBox.Show($"Error: {ex.Message}");        
                }
            }
        }
    }
}
