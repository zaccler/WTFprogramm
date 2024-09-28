using System;
using System.Windows;
using System.Windows.Navigation;

namespace WTFprogramm
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Переход на Задачу 1
        private void btnTask1_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }

        // Переход на Задачу 2
        private void btnTask2_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }
        // Переход на Задачу 3
        private void btnTask3_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Uri("Page3.xaml", UriKind.Relative));
        }
        // Переход на Задачу 4
        private void btnTask4_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Uri("Page4.xaml", UriKind.Relative));
        }
        // Переход на Задачу 5
        private void btnTask5_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Uri("Page5.xaml", UriKind.Relative));
        }



    }
}
