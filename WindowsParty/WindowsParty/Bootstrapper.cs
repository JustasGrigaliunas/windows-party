using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using WindowsParty.Global;
using WindowsParty.ViewModels;
using WindowsParty.Views;

namespace WindowsParty
{
    public class Bootstrapper :BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            ApiPaths.SetPaths();
            DisplayRootViewFor<LoginViewModel>();
        }
    }
    
}
