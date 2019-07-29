using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static int countTheSum = 0;
        static void FindAGoodNumber(int a)
        {
            if(a % 2 != 0 && a > 0)
            {
                countTheSum = countTheSum + a;
            }
        }
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Введите число");
                a = Convert.ToInt32(Console.ReadLine());
                FindAGoodNumber(a);
            } while (a != 0);
            Console.WriteLine($"Сумма нечётных положительных чисел равна: {countTheSum}");
            Console.ReadKey();
        }
    }
}
