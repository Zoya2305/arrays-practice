using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool validN = false;

            // 1. Запрос N с проверкой (N > 0) и обработкой исключений
            while (!validN)
            {
                Console.Write("Введите количество элементов: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        validN = true;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: N должно быть больше 0. Попробуйте снова.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не целое число. Попробуйте снова.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число слишком большое. Попробуйте снова.");
                }
            }

            int[] numbers = new int[n];

            // 2. Заполнение массива с обработкой исключений
            for (int i = 0; i < n; i++)
            {
                bool validElement = false;
                while (!validElement)
                {
                    Console.Write($"Элемент [{i}]: ");
                    try
                    {
                        numbers[i] = int.Parse(Console.ReadLine());
                        validElement = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введено не целое число. Попробуйте снова.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: число слишком большое. Попробуйте снова.");
                    }
                }
            }

            Console.WriteLine();

            // 3. Вывод массива в прямом порядке
            Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");

            // 4. Вывод массива в обратном порядке
            // Создаем копию, чтобы не испортить исходный массив
            int[] reversed = (int[])numbers.Clone();
            Array.Reverse(reversed);
            Console.WriteLine($"Обратный порядок: {string.Join(", ", reversed)}");

            // 5. Сортировка по возрастанию и вывод
            int[] sorted = (int[])numbers.Clone(); // Копируем, чтобы не менять исходный
            Array.Sort(sorted);
            Console.WriteLine($"Отсортированный: {string.Join(", ", sorted)}");

            // 6. Найти максимальный и минимальный элементы (без LINQ)
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}
