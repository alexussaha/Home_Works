using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
   
    class Program
    {
        static int CountOfDigits(int a)
        {
            int count = 0;
            while (a != 0)
            {
                a = a / 10;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Колличество цифр в чиле: {CountOfDigits(a)}");
            Console.ReadKey();
        }
    }
}
