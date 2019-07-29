using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static double Min_Between_Three(double a, double b, double c)
        {
            double min = a;
            if (b < a && b < c) min = b;
            else if (c < b && c < a) min = c;
            return min;
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Минимальное из {a}, {b} и {c}: {Min_Between_Three(a, b, c)}");
            Console.ReadKey();
        }
    }
}
