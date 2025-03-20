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
        public List<Product> product = App.context.Product.ToList();
        public AdminProductsPage()
        {
            InitializeComponent();
            ProductLb.ItemsSource = product;

            FilterCmb.SelectedValuePath = "Id";
            FilterCmb.DisplayMemberPath = "Title";
            FilterCmb.ItemsSource = App.context.TypeOfProduct.ToList();

            App.context.TypeOfProduct.ToList().Insert(0, new TypeOfProduct() { Title = "Все типы" });
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

            ProductLb.ItemsSource = product.
               Where(p => p.Title.Contains(ProductTb.Text)).ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ProductLb.SelectedItem == null)
            {
                MessageBoxHelper.Information("Выберите шоу для удаления");
                return;
            }

            Product selectedProduct = ProductLb.SelectedItem as Product;

            var res = MessageBox.Show($"Вы уверены, что хотите удалить?",
                "Подтверждение", MessageBoxButton.YesNo);

            if (res == MessageBoxResult.Yes)
            {
                App.context.Product.Remove(selectedProduct);
                App.context.SaveChanges();
                MessageBoxHelper.Information("Удалено");
            }
            ProductLb.ItemsSource = App.context.Product.ToList();
        }
        

        private void FilterCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TypeOfProduct typeOfProduct = FilterCmb.SelectedItem as TypeOfProduct;
            if (FilterCmb.SelectedIndex != 0)
            {
                ProductLb.ItemsSource = product.Where(x => x.TypeOfProduct.Id == typeOfProduct.Id);

            }
            else
            {
                ProductLb.ItemsSource = product;
            }
            
        }


        private void SelectProductBtn_Click_1(object sender, RoutedEventArgs e)
        {



            var button = sender as Button;
            if (button == null) return;

            var selectedProduct = button.DataContext as Product;
            if (selectedProduct == null) return;
            NavigationService.Navigate(new View.Pages.AdminInformationProductPage(selectedProduct));
        }
    }
}
