using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;
using TrainingProject.Proxy.Services;
using TrainingProject.Shared.DTOs;
using TrainingProject.Shared.DTOs.Companies;

namespace TrainingProject.Proxy.ViewModels
{
    public class CompanyViewModel : INotifyPropertyChanged
    {
        private string _companyName;
        private string _street;
        private string _city;
        private string _country;
        private string _phoneNumber;
        private string _email;
        private string _postalCode;
        private string _website;
        private readonly CompanyFormService companyFormService;
        public CompanyViewModel()
        {
            companyFormService = new CompanyFormService(new HttpClient());
        }
        public async Task<bool> AddCompanyAsync()
        {
            var company = new CompanyForCreationDto
            {
                Name = _companyName,
                City = _city,
                Street = _street,
                Country = _country,
                PhoneNumber = _phoneNumber,
                Email = _email,
                PostalCode = _postalCode,
                Website = _website
            };
            try
            {
                StatusMessage = "Company added.";
                return await companyFormService.AddAsync(company);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return false;
            }
        }
        public async Task<bool> UpdateCompanyAsync(Guid id)
        {
            var companyToUpdate = new CompanyForUpdateDto
            {
                Name = _companyName,
                City = _city,
                Street = _street,
                Country = _country,
                PhoneNumber = _phoneNumber,
                Email = _email,
                PostalCode = _postalCode,
                Website = _website
            };
            try
            {
                StatusMessage = "Company updated.";
                return await companyFormService.UpdateAsync(id, companyToUpdate);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return false;
            }
        }
        public async Task<bool> DeleteCompanyAsync(Guid id)
        {
            try
            {
                StatusMessage = "Company deleted";
                return await companyFormService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return false;
            }
        }
        public async Task<CompanyForResultDto> LoadCompanyByIdAsync(Guid id)
        {
            try
            {
                return await companyFormService.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return new CompanyForResultDto();
            }
        }
        public async Task LoadAllCompaniesAsync()
        {
            try
            {
                var companies = await companyFormService.GetAllAsync();
                Companies = new BindingList<CompanyForResultDto>(companies.ToList());
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                Companies = new BindingList<CompanyForResultDto>();
            }
        }
        private BindingList<CompanyForResultDto> _companies;
        public BindingList<CompanyForResultDto> Companies
        {
            get => _companies;
            set { _companies = value; OnPropertyChanged(nameof(CompanyForResultDto)); }
        }
        private string _statusMessage;
        public string StatusMessage
        {
            get => _statusMessage;
            set { _statusMessage = value; OnPropertyChanged(nameof(StatusMessage)); }
        }
        public string Name 
        {
            get => _companyName;
            set
            {
                _companyName = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Street
        {
            get => _street;
            set
            {
                _street = value;
                OnPropertyChanged(nameof(Street));
            }
        }
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged(nameof(City));
            }
        }
        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public string PostalCode
        {
            get => _postalCode;
            set
            {
                _postalCode = value;
                OnPropertyChanged(nameof(PostalCode));
            }
        }
        public string Website
        {
            get => _website;
            set
            {
                _website = value;
                OnPropertyChanged(nameof(Website));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
