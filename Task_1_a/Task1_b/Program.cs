using System;


/*         Усов Александр
 *         
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 * 
 * 
 */

namespace Task1_b
{
    class Complex
    {
        double im;
        double re;
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - this.im;
            x3.re = x2.re - this.re;
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
        public double Im {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public double Re
        {
            get { return re; }
            set
            {
                if (value >= 0) re = value;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.Re = 1;
            complex1.Im = 1;

            Complex complex2 = new Complex();
            complex2.Re = 2;
            complex2.Im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex2.Minus(complex1);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
