using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WTFprogramm
{
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void GenerateAndSwap_Click(object sender, RoutedEventArgs e)
        {
            
            Random random = new Random();
            int[] array = new int[6]; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-30, 30); 
            }

            
            OriginalArrayTextBlock.Text = "Исходный массив: " + string.Join(", ", array);

            // поиск первого чётного элемента
            int firstEvenIndex = Array.FindIndex(array, x => x % 2 == 0);
            // поиск последнего отрицательного элемента
            int lastNegativeIndex = Array.FindLastIndex(array, x => x < 0);

            if (firstEvenIndex != -1 && lastNegativeIndex != -1)
            {
                // обмен элементами
                int temp = array[firstEvenIndex];
                array[firstEvenIndex] = array[lastNegativeIndex];
                array[lastNegativeIndex] = temp;

                // вывод модифицированного массива
                ModifiedArrayTextBlock.Text = "Модифицированный массив: " + string.Join(", ", array);
            }
            else
            {
                if (firstEvenIndex == -1)
                    ModifiedArrayTextBlock.Text = "В массиве нет чётных элементов.";
                if (lastNegativeIndex == -1)
                    ModifiedArrayTextBlock.Text = "В массиве нет отрицательных элементов.";
            }
        }
    }
}
