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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColibriForSasha
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameHelper.MainUserFrame = MainUserFrame;
            MainUserFrame.Navigate(new View.Pages.MainPage());
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainUserFrame.Navigate(new View.Pages.MainPage());
        }


        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainUserFrame.Navigate(new View.Pages.ProfilePage());
        }

        private void ProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainUserFrame.Navigate(new View.Pages.ProductsPage());
        }
    }
}
