using ColibriForSasha.AppData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColibriForSasha.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminProductsPage.xaml
    /// </summary>
    public partial class AdminProductsPage : Page
    {
        public AdminProductsPage()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FilterCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void SelectProductBtn_Click_1(object sender, RoutedEventArgs e)
        {


            var button = sender as Button;
            if (button == null) return;

            var selectedProduct = button.DataContext as Product;
            if (selectedProduct == null) return;

            FrameHelper.MainAdminFrame.Navigate(new View.Pages.AdminInformationProductPage(selectedProduct));
        }
    }
}
