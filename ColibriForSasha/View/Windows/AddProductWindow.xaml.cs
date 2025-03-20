using ColibriForSasha.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {

        Product _product = new Product();
        public AddProductWindow()
        {
            InitializeComponent();



            TypeOfProductCmb.SelectedValuePath = "Id";
            TypeOfProductCmb.DisplayMemberPath = "Title";
            TypeOfProductCmb.ItemsSource = App.context.TypeOfProduct.ToList();
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product()
            {
                Title = TitleTb.Text,
                Description = DescriptionTb.Text,
                Price = Convert.ToDecimal(PriceTb.Text),
                TypeOfProduct = TypeOfProductCmb.SelectedItem as TypeOfProduct,
                StatusProductId = 1

            };
            App.context.Product.Add(product);
            App.context.SaveChanges();
            MessageBox.Show("Товар добавлен!");

            TitleTb.Text = "";
            DescriptionTb.Text = "";
            PriceTb.Text = "";
            TypeOfProductCmb.Text = "";

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPhotoBtn_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            

            MessageBox.Show("Фотография добавлена");
        }
    }
}
