using System;

namespace Lesson_3_4
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

            int d = (int)Math.Pow(b, 2) - 4 * a * c;

            if (d < 0) Console.WriteLine("Корней нет");
            else if (d == 0) Console.WriteLine($"Корень квадратного уравнения {(-b + Math.Sqrt(d)) / 2 * a}");
            else Console.WriteLine($"Корни квадратного уравнения: {(-b + Math.Sqrt(d)) / 2 * a} и {(-b - Math.Sqrt(d)) / 2 * a}");

        }
    }
}
