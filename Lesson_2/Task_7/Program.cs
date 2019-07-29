using System;


namespace Task_7
{
    class Program
    {
        static void RecOut(int start, int finish)
        {
            if (finish > start) RecOut(start, finish - 1);
            Console.WriteLine(finish);
        }
        static int SumOfNum(int a, int b)
        {
            if (b > a) return SumOfNum(a, b - 1) + b;
            return a;
        }
        static void Main(string[] args)
        {
            int a, b, s;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            RecOut(a, b);
            s = SumOfNum(a, b);
            Console.WriteLine();
            Console.WriteLine($"Сумма от {a} до {b} равна {s}");
            Console.ReadKey();

        }
    }
}
