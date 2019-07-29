using System;

namespace Task_5
{
    class Program
    {
        static string BodyMassIndex(double weight, double height)
        {
            string msg;
            double imb, needWeight;
            imb = weight / Math.Pow(height / 100, 2);
            if (imb < 18.5) msg = $"Вам нужно набрать {(18.5 * Math.Pow(height / 100, 2)) - weight:F2} кг.";
            else if(imb>25) msg = $"Вам нужно сбросить {weight - (25 * Math.Pow(height / 100, 2)):F2} кг.";
            else msg = "Всё в норме";

            return msg;
        }

        static void Main(string[] args)
        {
            double weight, height;
            Console.WriteLine("Введите вес");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(BodyMassIndex(weight, height));

            Console.ReadKey();

        }
    }
}
