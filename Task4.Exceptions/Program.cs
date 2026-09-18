using System;

namespace Task4.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создать массив из 5 элементов int
            int[] numbers = new int[5];

            // 2. Заполнить его с клавиатуры
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    try
                    {
                        // Пытаемся преобразовать введенную строку в число
                        numbers[i] = int.Parse(Console.ReadLine());
                        isValid = true; // Если ошибок нет, выходим из цикла while
                    }
                    catch (FormatException)
                    {
                        // Если введено не число
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        // Если число слишком большое или маленькое для типа int
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            // 3. Запросить индекс для вывода
            bool indexValid = false;
            while (!indexValid)
            {
                Console.Write($"Введите индекс для вывода (0-{numbers.Length - 1}): ");
                try
                {
                    int index = int.Parse(Console.ReadLine());
                    // Если индекс в пределах массива, выводим элемент
                    Console.WriteLine($"Элемент с индексом {index}: {numbers[index]}");
                    indexValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
                catch (IndexOutOfRangeException)
                {
                    // Если индекс вне границ массива (например, -1 или 10)
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
            }
        }
    }
}
