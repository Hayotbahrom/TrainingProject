using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Proxy.Services;
using TrainingProject.Shared.DTOs.Contacts;

namespace TrainingProject.Proxy.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private readonly ContactFormService _contactFormService;
        public ContactViewModel()
        {
            _contactFormService = new ContactFormService(new HttpClient());
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
        private string _statusMessage;
        public string StatusMessage
        {
            get => _statusMessage;
            set { _statusMessage = value; OnPropertyChanged(nameof(StatusMessage)); }
        }
        public async Task<bool> AddContactAsync()
        {
            var contact = new ContactForCreationDto
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Position = Position,
                CompanyId = CompanyId,
                Notes = Notes
            };
            try
            {
                StatusMessage = "Successfully added.";
                return await _contactFormService.AddAsync(contact);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return false;
            }
        }
        public async Task<bool> UpdateContactAsync(Guid id)
        {
            var contactToUpdate = new ContactForUpdateDto
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Position = Position,
                CompanyId = CompanyId,
                Notes = Notes
            };
            try
            {
                StatusMessage = "Successfully updated";
                return await _contactFormService.UpdateAsync(id, contactToUpdate);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return false;
            }
        }
        public async Task<bool> DeleteContactAsync(Guid id)
        {
            try
            {
                return await _contactFormService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return false;
            }
        }
        public async Task<IEnumerable<ContactForResultDto>> LoadAllContactsAsync()
        {
            try
            {
                return await _contactFormService.GetAllAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
                return Enumerable.Empty<ContactForResultDto>();
            }
        }
    }
}
