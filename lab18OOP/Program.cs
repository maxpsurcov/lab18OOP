using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Оголошення та ініціалізація масиву
            double[] arr = { 3.5, 0, 2.2, -1.7, 0, 8.1, 4.6 };

            // Обчислення мінімального елементу масиву
            double min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Мінімальний елемент масиву: {min}");

            // Обчислення суми елементів між першим і другим додатними елементами
            double sum = 0;
            bool foundFirstPositive = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (foundFirstPositive)
                    {
                        break;
                    }
                    foundFirstPositive = true;
                }
                else if (foundFirstPositive)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Сума елементів між першим і другим додатніми елементами: {sum}");

            // Перетворення масиву
            int zeroIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    double temp = arr[i];
                    arr[i] = arr[zeroIndex];
                    arr[zeroIndex] = temp;
                    zeroIndex++;
                }
            }

            // Виведення результатів
            Console.Write("Перетворений масив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            // Оголошення та ініціалізація двовимірного масиву
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Виведення масиву на консоль
            Console.WriteLine("Двовимірний масив:");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Порівняння елементів
            int bottomLeft = arr1[arr1.GetLength(0) - 1, 0];
            int bottomRight = arr1[arr1.GetLength(0) - 1, arr1.GetLength(1) - 1];
            Console.WriteLine($"Елементи нижнього рядка: {bottomLeft}, {bottomRight}");
            if (bottomLeft < bottomRight)
            {
                Console.WriteLine($"Елемент у нижньому лівому куті менший: {bottomLeft}");
            }
            else
            {
                Console.WriteLine($"Елемент у нижньому правому куті менший: {bottomRight}");
            }

            int upperRight = arr1[0, arr1.GetLength(1) - 1];
            Console.WriteLine($"Елемент у верхньому правому куті: {upperRight}");
            if (bottomLeft < upperRight)
            {
                Console.WriteLine($"Елемент у нижньому лівому куті менший: {bottomLeft}");
            }
            else
            {
                Console.WriteLine($"Елемент у верхньому правому куті менший: {upperRight}");
            }
            Console.ReadKey();
        }
    }

}

