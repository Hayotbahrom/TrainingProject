using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Proxy.Services;

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
