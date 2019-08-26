using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public delegate double Fun(double x);
    public delegate double Fun2(double a, double x);
    class Program
    {
        /// <summary>
        /// Метод, выводящий таблицу значений функции в промежутке от х1 до х2.
        /// </summary>
        /// <param name="F">Функция, принимающая два аргумента типа double и возвращающая значение double</param>
        /// <param name="a">Константа типа "double"</param>
        /// <param name="x1">Значение, начиная с которого будет выводиться таблица</param>
        /// <param name="x2">Значение, до которого будет выводиться таблица</param>
        public static void Table(Fun2 F, double a, double x1, double x2)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x1 <= x2)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x1, F?.Invoke(a, x1) /*F(a)*/);
                x1 += 1;
            }
            Console.WriteLine("---------------------");
        }
        /// <summary>
        /// Функция а*х^2
        /// </summary>
        /// <param name="a">Константа "а" в функции "a*x^2"</param>
        /// <param name="x">Переменная "x" в функции "a*x^2"</param>
        /// <returns></returns>
        public static double MyFuncAX2(double a, double x)
        {
            return a * x * x;
        }
        /// <summary>
        /// Функция а*sin(х)
        /// </summary>
        /// <param name="a">Константа "а" в функции "а*sin(х)"</param>
        /// <param name="x">Переменная "x" в функции "a*x^2"</param>
        /// <returns></returns>
        public static double MyFuncASin(double a, double x)
        {
            return a * Math.Sin(x);
        }
        static void Main(string[] args) { 


            Fun2 ax2 = new Fun2(MyFuncAX2);
            double a = 2;
            double x1 = -5;
            double x2 = 5;
            Console.WriteLine($"Таблца для y = {a}*x^2 для значений, x принадлежит от {x1} до {x2}");
            Table(ax2, a, x1, x2);
            Console.WriteLine("---------------------");
            Fun2 aSinX = new Fun2(MyFuncASin);
            Console.WriteLine($"Таблца для y = {a}*sin(x) для значений, x принадлежит от {x1} до {x2}");
            Table(aSinX, a, x1, x2);



        }
    }
}
