using System;

namespace UnitStudent
{
    public static class corectInput
    {
        public static bool inputDouble(ref double x, string povidom)
        {
            while (true)
            {
                Console.Write($"{povidom} (введіть дійсне число): ");
                string? s = Console.ReadLine();
                try
                {
                    x = Convert.ToDouble(s);
                    return true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ви увели не дійсне число. Бажаєте повторити? (y/n)");
                    Console.ResetColor();
                    string? choice = Console.ReadLine()?.Trim().ToLower();
                    if (choice != "y" && choice != "н" && choice != "yes" && choice != "так")
                    {
                        return false;
                    }
                }
            }
        }

        public static bool inputInt(ref int x, string povidom)
        {
            while (true)
            {
                Console.Write($"{povidom} (введіть ціле число): ");
                string? s = Console.ReadLine();
                try
                {
                    x = Convert.ToInt32(s);
                    return true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ви увели не ціле число. Бажаєте повторити? (y/n)");
                    Console.ResetColor();
                    string? choice = Console.ReadLine()?.Trim().ToLower();
                    if (choice != "y" && choice != "н" && choice != "yes" && choice != "так")
                    {
                        return false;
                    }
                }
            }
        }
    }
}
