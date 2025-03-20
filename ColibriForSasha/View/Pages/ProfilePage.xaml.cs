using ColibriForSasha.AppData;
using ColibriForSasha.Model;
using ColibriForSasha.View.Windows;
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

namespace ColibriForSasha.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public List<Order> order = App.context.Order.ToList();
        public ProfilePage()
        {
            InitializeComponent();

            OrderLv.ItemsSource = App.context.Order.
                Where(u => u.User.Id == App.currentUser.Id).ToList();

            UserDataGrid.DataContext = App.context.User.ToList();
        }

        private void MoreInfBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditTb_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();

            MessageBoxHelper.Information("Информация успешно изменена!");
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {

            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            MainWindow mainWindow = new MainWindow();
            authorizationWindow.Show();
            mainWindow.Close();
        }
    }
}
