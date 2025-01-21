using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Proxy.Services;
using TrainingProject.Shared.DTOs.Users;

namespace TrainingProject.Proxy.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged 
    {
        private string _username;
        private string _password;
        private string _loginMessage;
        private string _confirmedPassword;                      
        private readonly LoginFormService _formService;
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LoginViewModel() 
        {
            _formService = new LoginFormService(new HttpClient());
        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string LoginMessage
        {
            get => _loginMessage;
            set
            {
                _loginMessage = value;
                OnPropertyChanged(nameof(LoginMessage));
            }
        }
        public string ConfirmedPassword
        {
            get => _confirmedPassword;
            set
            {
                _confirmedPassword = value;
                OnPropertyChanged(nameof(ConfirmedPassword));
            }
        }
        public async Task<bool> LoginAsync()
        {
            var loginModel = new UserForCreationDto
            {
                Username = Username,
                Password = Password,
            };
            try
            {
                var tokenResponse = await _formService.LoginAsync(loginModel);
                if (tokenResponse != null)
                {
                    LoginMessage = "Login Successfully.";
                    return true;
                }
                else
                {
                    LoginMessage = "Login failed. No valid token was returned.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                LoginMessage = $"Login failed. Error: {ex.Message}";
                return false;
            }
        }
        public async Task<bool> RegisterAsync()
        {
            if (Password != ConfirmedPassword)
            {
                LoginMessage = "Password do not match";
                return false;
            }
            else
            {
                bool isRegistered = await _formService.RegisterAsync(Username, Password);
                if (isRegistered)
                {
                    LoginMessage = $"{Username} Registered successfully";
                    return true;
                }
                else
                {
                    LoginMessage = "Registration failed. Please try again.";
                    return false;
                }
            }
        }
    }
}
