using System;
namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели, с которого начинается месяц (1-пн,...7-вс)");
            int start = Convert.ToInt32(Console.ReadLine());
            if ((start < 1) || (start > 7))
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                Console.WriteLine("Введите день");
                int day = Convert.ToInt32(Console.ReadLine());
                if ((day < 1) || (day > 31))
                {
                    Console.WriteLine("Ошибка");
                }
                if ((((day >= 1) && (day <= 5)) || ((day >= 8) && (day <= 10))))
                {
                    Console.WriteLine("Выходной");
                }
                else if ((((start - 1 + day) % 7) == 6) || (((start - 1 + day) % 7) == 0))
                {
                    Console.WriteLine("Выходной");
                }
                else
                {
                    Console.WriteLine("Рабочий день:(");
                }
            }
        }
    }
}
