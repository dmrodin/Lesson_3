using System;

namespace Lesson_3_3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && a >= c && b >= c) Console.WriteLine($"{c} {b} {a}");
            else if (a >= b && a >= c && b < c) Console.WriteLine($"{b} {c} {a}");
            else if (a < b && a >= c && b >= c) Console.WriteLine($"{c} {a} {b}");
            else if (a < b && a < c && b >= c) Console.WriteLine($"{a} {c} {b}");
            else if (a >= b && a < c && b < c) Console.WriteLine($"{b} {a} {c}");
            else Console.WriteLine($"{a} {b} {c}");
        }
    }
}
