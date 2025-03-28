﻿using ColibriForSasha.Model;
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
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        public List<Product> product = App.context.Product.ToList();
        public List<TypeOfProduct> typeOfProduct = App.context.TypeOfProduct.ToList();
        public ProductsPage()
        {
            InitializeComponent();
            ProductLb.ItemsSource = product;

            FilterCmb.SelectedValuePath = "Id";
            FilterCmb.DisplayMemberPath = "Title";
            FilterCmb.ItemsSource = App.context.TypeOfProduct.ToList();

            typeOfProduct.Insert(0, new TypeOfProduct() { Title = "Все типы" });



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

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            ProductLb.ItemsSource = product.
               Where(p => p.Title.Contains(ProductTb.Text)).ToList();
        }

        

        private void SelectProductBtn_Click_1(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            var selectedProduct = button.DataContext as Product;
            if (selectedProduct == null) return;
            NavigationService.Navigate(new View.Pages.InformationProductPage(selectedProduct));
        }
    }
}
