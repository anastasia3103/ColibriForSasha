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
    /// Логика взаимодействия для AdminOrdersPage.xaml
    /// </summary>
    public partial class AdminOrdersPage : Page
    {
        private List<StatusOrder> statusOrder = App.context.StatusOrder.ToList();

        public AdminOrdersPage()
        {
            InitializeComponent();

            OrderLv.ItemsSource = App.context.Order.ToList();

            StatusOrderCmb.SelectedValuePath = "Id";
            StatusOrderCmb.DisplayMemberPath = "Title";
            StatusOrderCmb.ItemsSource = statusOrder;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrderLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductDetailsGrid.DataContext = OrderLv.SelectedItem as Order;
        }

        private void StatusOrderCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
