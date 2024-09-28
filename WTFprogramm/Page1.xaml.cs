using System;
using System.Windows;
using System.Windows.Controls;

namespace WTFprogramm
{
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputNumber.Text, out int number))
            {
                ResultTextBlock.Text = GetNumberDescription(number);
            }
            else
            {
                MessageBox.Show("Введите корректное целое число.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string GetNumberDescription(int number)
        {
            if (number == 0) return "Нулевое число";
            string sign = number > 0 ? "Положительное" : "Отрицательное";
            string digits = Math.Abs(number) < 10 ? "однозначное" :
                            Math.Abs(number) < 100 ? "двузначное" : "трехзначное";
            return $"{sign} {digits} число";
        }
    }
}
