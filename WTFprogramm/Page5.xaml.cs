using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WTFprogramm
{
    public partial class Task5Page : Page
    {
        private const int M = 5; // кол во столбцов
        private const int N = 5; // кол во строк

        public Task5Page()
        {
            InitializeComponent();
        }

        private void GenerateAndSort_Click(object sender, RoutedEventArgs e)
        {
            
            Random random = new Random();
            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = random.Next(-10, 11); 
                }
            }

            // преобразуем двумерный массив в одномерный для сортировки
            int[] flatArray = array.Cast<int>().ToArray();

            // сортировка массива по возрастанию и убыванию
            int[] sortedAscending = flatArray.OrderBy(x => x).ToArray();
            int[] sortedDescending = flatArray.OrderByDescending(x => x).ToArray();

            // нахождение минимального и максимального элементов
            int minElement = flatArray.Min();
            int maxElement = flatArray.Max();

            // отображение исходного массива
            DisplayArray(array, OriginalArrayGrid);

            // отображение отсортированного массива по возрастанию
            DisplayFlatArrayAs2D(sortedAscending, SortedAscendingGrid);

            // отображение отсортированного массива по убыванию
            DisplayFlatArrayAs2D(sortedDescending, SortedDescendingGrid);

            // вывод максимального и минимального элементов
            MinMaxTextBlock.Text = $"Минимальный элемент: {minElement}, Максимальный элемент: {maxElement}";
        }

        // метод для отображения двумерного массива в DataGrid
        private void DisplayArray(int[,] array, DataGrid grid)
        {
            grid.Columns.Clear();
            for (int i = 0; i < array.GetLength(1); i++)
            {
                grid.Columns.Add(new DataGridTextColumn { Header = $"Col {i + 1}", Binding = new System.Windows.Data.Binding($"[{i}]") });
            }

            var items = new object[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var row = new object[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    row[j] = array[i, j];
                }
                items[i] = row;
            }
            grid.ItemsSource = items;
        }

        // метод для отображения одномерного массива как двумерного в грид
        private void DisplayFlatArrayAs2D(int[] array, DataGrid grid)
        {
            grid.Columns.Clear();
            for (int i = 0; i < M; i++)
            {
                grid.Columns.Add(new DataGridTextColumn { Header = $"Col {i + 1}", Binding = new System.Windows.Data.Binding($"[{i}]") });
            }

            var items = new object[N];
            for (int i = 0; i < N; i++)
            {
                var row = new object[M];
                for (int j = 0; j < M; j++)
                {
                    row[j] = array[i * M + j];
                }
                items[i] = row;
            }
            grid.ItemsSource = items;
        }
    }
}
