using System;

/*    Усов Александр

    3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    ArgumentException("Знаменатель не может быть равен 0");
    Добавить упрощение дробей.


*/
namespace Task_3
{
    class Fraction
    {
        int numerator;
        int denumerator;

        public Fraction()
        {

        }

        static int nod(int a, int b)
        {
            if (b < 0)
                b = -b;
            if (a < 0)
                a = -a;
            while (b > 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
       static int nok(int a, int b)
        {
            return Math.Abs(a * b) / nod(a, b);
        }

         public static Fraction operator + (Fraction A, Fraction B)
        {
            Fraction C = new Fraction();
            if (A.denumerator == B.denumerator)
            {
                C.numerator = A.numerator + B.numerator;
                C.denumerator = A.denumerator;

            }
            else
            {
                C.denumerator = nok(B.denumerator, A.denumerator);
                C.numerator = A.numerator * C.denumerator / A.denumerator + B.numerator * C.denumerator / B.denumerator;

            }
            return C;
        }

        public static Fraction operator - (Fraction A, Fraction B)
        {
            Fraction C = new Fraction();
            if (A.denumerator == B.denumerator)
            {
                C.numerator = A.numerator - B.numerator;
                C.denumerator = A.denumerator;

            }
            else
            {
                C.denumerator = nok(B.denumerator, A.denumerator);
                C.numerator = A.numerator * C.denumerator / A.denumerator - B.numerator * C.denumerator / B.denumerator;

            }
            return C;
        }


        public static Fraction operator * (Fraction A, Fraction B)
        {
            Fraction C = new Fraction();
            C.numerator = A.numerator * B.numerator;
            C.denumerator = A.denumerator * B.denumerator;
            return C;
        }


        public static Fraction operator / (Fraction A, Fraction B)
        {
            Fraction C = new Fraction();
            C.numerator = A.numerator * B.denumerator;
            C.denumerator = A.denumerator * B.numerator;
            return C;
        }


        public Fraction Plus(Fraction A)
        {
            Fraction B = new Fraction();
            if (denumerator == A.denumerator)
            {
                B.numerator = numerator + A.numerator;
                B.denumerator = denumerator;

            }
            else
            {
                B.denumerator = nok(denumerator, A.denumerator);
                B.numerator = numerator * B.denumerator / denumerator + A.numerator * B.denumerator / A.denumerator;

            }
            return B;
        }

        public Fraction Minus(Fraction A)
        {
            Fraction B = new Fraction();
            if (denumerator == A.denumerator)
            {
                B.numerator = numerator - A.numerator;
                B.denumerator = denumerator;

            }
            else
            {
                B.denumerator = nok(denumerator, A.denumerator);
                B.numerator = numerator * B.denumerator / denumerator - A.numerator * B.denumerator / A.denumerator;
            }
            return B;
        }

        public Fraction Multy(Fraction A)
        {
            Fraction B = new Fraction();
            B.numerator = numerator * A.numerator;
            B.denumerator = denumerator * A.denumerator;
            return B;

        }

        public Fraction Devide(Fraction A)
        {
            Fraction B = new Fraction();
            B.numerator = numerator * A.denumerator;
            B.denumerator = denumerator * A.numerator;
            return B;

        }
        public int Numerator
        {
            set
            {
                numerator = value;
            }
        }
        public int Denumerator
        {
            set
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен нулю");
               else  denumerator = value;
            }
        }
        public void Print()
        {
            Console.WriteLine($"   {numerator}/{denumerator}  ");
        }
        public double GetDouble()
        {
            return (double) numerator / denumerator;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction A = new Fraction();
            Fraction B = new Fraction();
            Fraction C = new Fraction();
            Console.WriteLine("Введите первую дробь");
            Console.WriteLine("Введите числитель: ");
            A.Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель: ");
            A.Denumerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую дробь");
            Console.WriteLine("Введите числитель: ");
            B.Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель: ");
            B.Denumerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма: ");
            C = A.Plus(B);
            C.Print();
            Console.WriteLine("Разность: ");
            C = A.Minus(B);
            C.Print();
            Console.WriteLine("Произведение: ");
            C = A.Multy(B);
            C.Print();
            Console.WriteLine("Деление: ");
            C = A.Devide(B);
            C.Print();
            Console.WriteLine("Выражения при помощи переопределения операторов:");
            Console.WriteLine("Сумма: ");
            C = A + B;
            C.Print();
            Console.WriteLine("Разность: ");
            C = A - B;
            C.Print();
            Console.WriteLine("Произведение: ");
            C = A * B;
            C.Print();
            Console.WriteLine("Деление: ");
            C = A / B;
            C.Print();
            Console.WriteLine(C.GetDouble());
            Console.ReadKey();
        }
    }
}
