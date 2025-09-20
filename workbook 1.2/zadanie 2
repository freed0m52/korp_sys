using System;
namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму для обналичивания");
            int summa = Convert.ToInt32(Console.ReadLine());
            if ((summa > 150000) || (summa <= 0))
            {
                Console.WriteLine("Найдите банкомат побогаче:(");
            }
            else if (summa % 100 != 0)
            {
                Console.WriteLine("Не не, не угадал");
            }
            else
            {
                int k_5k = summa / 5000;
                summa = summa % 5000;
                int k_2k = summa / 2000;
                summa = summa % 2000;
                int k_1k = summa / 1000;
                summa = summa % 1000;
                int k_5s = summa / 500;
                summa = summa % 500;
                int k_2s = summa / 200;
                summa = summa % 200;
                int k_1s = summa / 100;
                summa = summa % 100;
                Console.WriteLine($"{k_5k} по 5000, {k_2k} по 2000, {k_1k} по 1000, {k_5s} по 500, {k_2s} по 200, {k_1s} по 100");
            }
        }
    }
}
