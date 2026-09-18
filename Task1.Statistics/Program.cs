using System;
using System.Linq;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создать массив из 10 случайных чисел в диапазоне [1, 100]
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101); // 101, так как верхняя граница не включается
            }

            // 2. Вывести массив в одну строку через string.Join
            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            // 3. Найти и вывести:

            // Сумму всех элементов
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Сумма: {sum}");

            // Произведение всех элементов
            long product = 1; // Используем long, так как произведение может быть очень большим
            foreach (int num in numbers)
            {
                product *= num;
            }
            Console.WriteLine($"Произведение: {product}");

            // Количество чётных чисел
            int evenCount = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine($"Чётных чисел: {evenCount}");

            // Количество чисел, больших среднего арифметического
            double average = (double)sum / numbers.Length;
            int aboveAverageCount = 0;
            foreach (int num in numbers)
            {
                if (num > average)
                {
                    aboveAverageCount++;
                }
            }
            // В примере вывода среднее округляется до одного знака (46.7)
            Console.WriteLine($"Больше среднего ({average:F1}): {aboveAverageCount}");
        }
    }
}