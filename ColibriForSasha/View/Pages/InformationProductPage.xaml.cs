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
    /// Логика взаимодействия для InformationProductPage.xaml
    /// </summary>
    public partial class InformationProductPage : Page
    {

        private Product _selectedProduct;

        public InformationProductPage(object selectedProduct)
        {
            InitializeComponent();
            _selectedProduct = selectedProduct as Product;

            DataContext = selectedProduct;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if(_selectedProduct != null)
        {
                Order order = new Order()
                {
                    IdUser = App.currentUser.Id,
                    IdProduct = _selectedProduct.Id,
                    Date = DateTime.Now,
                    StatusOrderId = 1
                };

                App.context.Order.Add(order);
                App.context.SaveChanges();

                MessageBox.Show("Товар добавлен в заказ!");
            }
        else
            {
                MessageBox.Show("Товар не выбран!");
            }

            

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainUserFrame.Navigate(new View.Pages.ProductsPage());
        }
    }
}
