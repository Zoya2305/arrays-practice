//Вариант 0
using System;
using System.Linq;

namespace Final.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // ВАЖНО: Укажите здесь свой номер варианта!
            Console.WriteLine("=== Вариант 0: Успеваемость студентов ===");

            string[] students = { "Анна", "Борис", "Виктор", "Галина" };
            int[] grades = { 85, 92, 78, 95 };

            // 1. Вывод таблицы с выравниванием
            Console.WriteLine("\nТаблица оценок:");
            Console.WriteLine("{0,-10} | {1,5}", "Имя", "Баллы");
            Console.WriteLine(new string('-', 18));
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("{0,-10} | {1,5}", students[i], grades[i]);
            }

            // 2. Поиск лучшего студента (Array.IndexOf + Max)
            int maxGrade = grades.Max(); // Находим максимальный балл
            int bestIndex = Array.IndexOf(grades, maxGrade); // Находим его индекс
            Console.WriteLine($"\nЛучший студент: {students[bestIndex]} ({maxGrade} баллов)");

            // 3. Средний балл группы
            double average = grades.Average();
            Console.WriteLine($"Средний балл группы: {average:F1}");
        }
    }
}
