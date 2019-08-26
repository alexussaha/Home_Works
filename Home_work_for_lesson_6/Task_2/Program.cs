using System;
using System.IO;
using System.Collections.Generic;

namespace Task_2
{
    public delegate double Func(double x);
    class Program
    {
        public static double F(double x)
        {
            return x * x;
        }

        public static void SaveFunc(string fileName, Func Function, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            //            StreamWriter sw = new StreamWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Function(x));
                //                sw.WriteLine(F(x));
                x += h;//x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            double d;
            min = double.MaxValue;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }
        public static void PrintArray(double[] array)
        {
            foreach (double el in array) Console.WriteLine(el + " ");

        }
        static void Main(string[] args)
        {
            double min;
            List <Func>  function = new List<Func>();
            function.Add(F);
            function.Add(Math.Sin);
            function.Add(Math.Cos);
            function.Add(Math.Tan);
            function.Add(Math.Sqrt);
            Console.WriteLine("Введите цифру, соответствующую той функции, которую хотите вызвать.\n 1 - x^2\n 2 - Sin(x)\n 3 - Cos(x)\n 4 - Tan(x)\n 5 - Sqrt(x):");
            int i;
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало отрезка");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            double h = double.Parse(Console.ReadLine());
            SaveFunc("data.bin", function[i-1], a, b, h);
            Console.WriteLine("Выведем сохранённый массив");
            PrintArray(Load("data.bin", out min));
            Console.WriteLine($"min = {min}");
            Console.ReadKey();
        }
    }
}
