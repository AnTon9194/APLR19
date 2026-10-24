using System;
using UnitStudent;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Демонстрація роботи власної бібліотеки===");
            
            // 1. Тестування analizText
            Console.WriteLine("\n--- Тест 1: Обробка рядків (analizText) ---");
            Console.Write("Введіть рядок для підрахунку розділових знаків: ");
            string text = Console.ReadLine() ?? "";
            int count = 0;
            foreach (char c in text)
            {
                if (analizText.rozdilZnak(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Кількість розділових знаків та пробілів у рядку: {count}");

            // 2. Тестування corectInput
            Console.WriteLine("\n--- Тест 2: Коректне введення чисел (corectInput) ---");
            double dVal = 0;
            if (corectInput.inputDouble(ref dVal, "Введіть коефіцієнт A"))
            {
                Console.WriteLine($"Успішно введено double: {dVal}");
            }
            else
            {
                Console.WriteLine("Введення скасовано користувачем.");
            }

            int iVal = 0;
            if (corectInput.inputInt(ref iVal, "Введіть кількість ітерацій"))
            {
                Console.WriteLine($"Успішно введено int: {iVal}");
            }
            else
            {
                Console.WriteLine("Введення скасовано користувачем.");
            }

            Console.WriteLine("\nПрограма завершила роботу. Натисніть Enter для виходу.");
            Console.ReadLine();
        }
    }
}
