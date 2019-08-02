using System;

namespace Task_2
{
    class Program
    {
        static void IfOdd(int n, ref int s)
        {
            if (n % 2 > 0)
            {
                s += n;
            }
        }
      
        static void Main(string[] args)
        {
            string number;
            int n, s = 0;
            Console.WriteLine("Вводите целые числа. Для завершения программы введите ноль.");
            do
            {
                number = Console.ReadLine();
                if (int.TryParse(number, out n))
                {
                   n = int.Parse(number);
                   IfOdd(n, ref s);
                    
                }
                else
                {
                    Console.WriteLine("Неверный ввод (введите цедлое чило)");
                    n = 1;
                }
            } while (n != 0);
            Console.WriteLine($"Сумма нечётных чисел равна: {s}");
            Console.ReadKey();
        }
    }
}
