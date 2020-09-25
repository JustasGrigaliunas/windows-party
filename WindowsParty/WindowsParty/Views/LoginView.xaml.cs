using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WindowsParty.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pasw = (PasswordBox)sender;
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = pasw.Password; }

            if (pasw.Password.Length == 0)
                PasswordHint.Visibility = Visibility.Visible;
            else
                PasswordHint.Visibility = Visibility.Collapsed;
        }
    }
}
