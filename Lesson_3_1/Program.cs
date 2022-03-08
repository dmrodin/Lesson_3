using System;

namespace Lesson_3_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b) Console.WriteLine($"A + B = {a + b}");
            else if(a == b) Console.WriteLine($"A * B = {a * b}");
            else Console.WriteLine($"A - B = {a - b}");
        }
    }
}
