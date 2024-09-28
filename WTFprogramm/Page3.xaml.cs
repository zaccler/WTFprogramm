using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WTFprogramm
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // получение массива координат
                var coordinates = InputCoordinates.Text
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .OrderBy(x => x)
                    .ToArray();

                if (coordinates.Length == 0)
                {
                    MessageBox.Show("Введите хотя бы одну координату.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // поиск медианы
                double median;
                int n = coordinates.Length;

                if (n % 2 == 1)
                {
                    // нечётное количество точек — медиана это средняя точка
                    median = coordinates[n / 2];
                }
                else
                {
                    // чётное количество точек — медиана это среднее двух средних точек
                    median = (coordinates[n / 2 - 1] + coordinates[n / 2]) / 2;
                }

                // рассчёт суммы расстояний от медианы до всех точек
                double sumOfDistances = coordinates.Sum(point => Math.Abs(point - median));

                ResultTextBlock.Text = $"Точка с минимальной суммой расстояний: {median}\n" +
                                       $"Сумма расстояний: {sumOfDistances}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
