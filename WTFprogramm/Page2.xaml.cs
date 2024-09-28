using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WTFprogramm
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            string input = InputString.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите строку с русскими словами.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // разбитие строки на слова (убираем лишние пробелы, нахождение длину самого длинного слова)
            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var longestWordLength = words.Max(word => word.Length);

            ResultTextBlock.Text = $"Длина самого длинного слова: {longestWordLength}";
        }
    }
}
