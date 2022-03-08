using System;

namespace Lesson_3_5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите двузначное число: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value < 10 || value > 99) 
            {
                Console.WriteLine("Введено не двузначное число");
            } 
            else if (value >= 10 && value <= 19)
            {
                switch (value)
                {
                    case 10: Console.WriteLine("десять"); break;
                    case 11: Console.WriteLine("одинадцать"); break;
                    case 12: Console.WriteLine("двенадцать"); break;
                    case 13: Console.WriteLine("тринадцать"); break;
                    case 14: Console.WriteLine("четырнадцать"); break;
                    case 15: Console.WriteLine("пятнадцать"); break;
                    case 16: Console.WriteLine("шестьнадцать"); break;
                    case 17: Console.WriteLine("семнадцать"); break;
                    case 18: Console.WriteLine("восемнадцать"); break;
                    case 19: Console.WriteLine("девятнадцать"); break;
                }
            }
            else
            {
                int decimalPart = value / 10;
                int singlePart = value % 10;

                string firstWord = "";
                string secondWord = "";

                if (decimalPart == 2) firstWord = "двадцать";
                else if (decimalPart == 3) firstWord = "тридцать";
                else if (decimalPart == 4) firstWord = "сорок";
                else if (decimalPart == 5) firstWord = "пятьдесят";
                else if (decimalPart == 6) firstWord = "шестьдесят";
                else if (decimalPart == 7) firstWord = "семьдясят";
                else if (decimalPart == 8) firstWord = "восемьдесят";
                else firstWord = "девяносто";

                if (singlePart == 0) secondWord = "";
                else if (singlePart == 1) secondWord = "один";
                else if (singlePart == 2) secondWord = "два";
                else if (singlePart == 3) secondWord = "три";
                else if (singlePart == 4) secondWord = "четыре";
                else if (singlePart == 5) secondWord = "пять";
                else if (singlePart == 6) secondWord = "шесть";
                else if (singlePart == 7) secondWord = "семь";
                else if (singlePart == 8) secondWord = "восемь";
                else secondWord = "девять";

                Console.WriteLine(firstWord + " " + secondWord);
            }    

        }
    }
}
