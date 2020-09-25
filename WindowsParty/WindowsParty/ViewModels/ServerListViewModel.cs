using Caliburn.Micro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsParty.Global;
using WindowsParty.Models;

namespace WindowsParty.ViewModels
{
    public class ServerListViewModel : Conductor<object>
    {
        private BindableCollection<ServerListModel> _serverList = new BindableCollection<ServerListModel>();
        public BindableCollection<ServerListModel> ServerList
        {
            get 
            {
                return _serverList;
            }
            set
            {
                NotifyOfPropertyChange(() => ServerList);
            }
        }
        public ServerListViewModel(string serverListResponse)
        {
            _serverList = JsonConvert.DeserializeObject<BindableCollection<ServerListModel>>(serverListResponse);
        }
        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            if (_serverList.Count < 1)
            {
                MessageBox.Show("No servers found");
            }
            else
            {
                MessageBox.Show($"{_serverList.Count} servers found");
            }
        }
        public void LogOut()
        {
            UserInfo.ClearUserInfo();

            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new LoginViewModel(), null, null);
            TryClose();
        }
    }
}
