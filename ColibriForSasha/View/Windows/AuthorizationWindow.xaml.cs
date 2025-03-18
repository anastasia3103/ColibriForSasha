using ColibriForSasha.Model;
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

namespace ColibriForSasha.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void ConfHL_Click(object sender, RoutedEventArgs e)
        {

            ConfPolicyWindow confPolicyWindow = new ConfPolicyWindow();
            confPolicyWindow.ShowDialog();
        }

        private void RegistrationHL_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User currentUser = App.context.User.FirstOrDefault(p => p.Email == LoginTb.Text
                && p.Password == PasswordPb.Password);

                if (currentUser != null)
                {
                    App.currentUser = currentUser;
                    MessageBox.Show("Авторизация прошла успешно!");

                    if (currentUser.RoleId == 1)
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        Close();
                    }
                    else
                    {
                        AdminMainPage adminMainWindow = new AdminMainPage();
                        adminMainWindow.Show();
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
