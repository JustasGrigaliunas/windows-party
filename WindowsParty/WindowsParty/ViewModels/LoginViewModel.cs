using Caliburn.Micro;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsParty.Models;
using WindowsParty.Services;

namespace WindowsParty.ViewModels
{
    public class LoginViewModel: Conductor<object>
    {
        private string _username;
        private string _password;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => Username);
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }
        private readonly IAPIService _apiService;
        public LoginViewModel()
        {
            _apiService = new APIService();
        }
        public async void LogIn()
        {
            var successfull= await _apiService.LogIn(Username,Password);
            if (successfull)
            {
                var serverListJson = await _apiService.GetServerList();

                OpenServerList(serverListJson);
            }
            
        }
        public void OpenServerList(string serverListJson)
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new ServerListViewModel(serverListJson), null, null);
            TryClose();
        }

    }
}
