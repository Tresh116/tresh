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
using System.Windows.Navigation;
using System.Windows.Shapes;
using tresh.Components;

namespace tresh.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            string password = PasswordTb.Text;

            if (login.Length == 0 && password.Length == 0)
            {
                MessageBox.Show("Заполни");

            }
            else
            {
                Navigation.AuthUser = DbConnect.db.User.ToList().Find(x => x.Login == login && x.Password == password);
                if (Navigation.AuthUser == null)
                    MessageBox.Show("Такого пол-я не существует");
            }
        }

        private void RegistrBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
