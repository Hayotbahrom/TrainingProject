using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Proxy.Services;

namespace TrainingProject.Proxy.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private readonly ContactFormService contactFormService;
        public ContactViewModel()
        {
            contactFormService = new ContactFormService(new HttpClient());
        }
        private Guid _contactId;
        public Guid CompanyId 
        { 
            get => _contactId; 
            set { _contactId = value; OnPropertyChanged(nameof(CompanyId)); } 
        }
        private string _firstName;
        public string FirstName 
        { 
            get=> _firstName;
            set { _firstName = value;OnPropertyChanged(nameof(FirstName)); } 
        }
        private string _lastName;
        public string LastName 
        { 
            get => _lastName;
            set { _lastName = value; OnPropertyChanged(nameof(LastName)); } 
        }
        private string _email;
        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }
        private string _phone;
        public string PhoneNumber { 
            get => _phone;
            set { _phone = value; OnPropertyChanged(nameof(PhoneNumber)); }
        }
        private string _position;
        public string Position 
        { 
            get=> _position;
            set { _position = value; OnPropertyChanged(nameof(Position)); }
        }
        private string _notes;
        public string Notes 
        { 
            get => _notes;
            set { _notes = value; OnPropertyChanged(nameof(Notes)); }
        }
    }
}
