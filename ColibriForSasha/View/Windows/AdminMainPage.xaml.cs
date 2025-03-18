using ColibriForSasha.AppData;
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
    /// Логика взаимодействия для AdminMainPage.xaml
    /// </summary>
    public partial class AdminMainPage : Window
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainAdminFrame.Navigate(new View.Pages.AdminProductsPage());
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {

            FrameHelper.MainAdminFrame.Navigate(new View.Pages.AdminOrdersPage());
        }
    }
}
