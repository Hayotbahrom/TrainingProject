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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
