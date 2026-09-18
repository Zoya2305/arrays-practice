using System;

namespace Task3.Unique
{
    class Program
    {
        // Метод, который нужно было реализовать
        public static int[] GetUnique(int[] source)
        {
            // Создаем временный массив для результата.
            // Он не может быть длиннее исходного.
            int[] tempResult = new int[source.Length];
            int uniqueCount = 0; // Счетчик уникальных элементов

            // Перебираем все элементы исходного массива
            for (int i = 0; i < source.Length; i++)
            {
                bool isDuplicate = false;

                // Проверяем, встречался ли этот элемент ранее в tempResult
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (source[i] == tempResult[j])
                    {
                        isDuplicate = true;
                        break; // Нашли дубликат, дальше искать нет смысла
                    }
                }

                // Если элемент не дубликат — добавляем его в результат
                if (!isDuplicate)
                {
                    tempResult[uniqueCount] = source[i];
                    uniqueCount++;
                }
            }

            // Теперь нужно создать массив точного размера (uniqueCount)
            // и скопировать туда наши уникальные элементы
            int[] result = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = tempResult[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Тестовый массив из примера
            int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };

            Console.WriteLine($"Исходный: {string.Join(", ", source)}");

            // Вызываем наш метод
            int[] unique = GetUnique(source);

            Console.WriteLine($"Уникальные: {string.Join(", ", unique)}");
        }
    }
}