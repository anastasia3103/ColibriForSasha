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
    /// Логика взаимодействия для AdminInformationProductPage.xaml
    /// </summary>
    public partial class AdminInformationProductPage : Page
    {
        public AdminInformationProductPage(object selectedProduct)
        {
            InitializeComponent();

            DataContext = selectedProduct;

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

            App.context.SaveChanges();
            MessageBox.Show("Информация успешно изменена!");
        }

        private void StatusProductCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
