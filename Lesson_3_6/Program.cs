using System;

namespace Lesson_3_6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c || b + c > a || a + c > b) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}
