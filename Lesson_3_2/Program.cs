using System;

namespace Lesson_3_2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && y >= 0) Console.WriteLine("1");
            else if (x >= 0 && y < 0) Console.WriteLine("2");
            else if (x < 0 && y < 0) Console.WriteLine("3");
            else Console.WriteLine("4");
        }
    }
}
