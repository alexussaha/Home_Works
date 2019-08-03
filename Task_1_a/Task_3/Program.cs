using System;


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
                denumerator = value;
            }
        }
        public void Print()
        {
            Console.WriteLine($"   {numerator}/{denumerator}  ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction A = new Fraction();
            Fraction B = new Fraction();
            Fraction C = new Fraction();
            A.Numerator = 1;
            A.Denumerator = 2;
            B.Numerator = 1;
            B.Denumerator = 3;
            C = A.Plus(B);
            C.Print();
            C = A.Minus(B);
            C.Print();
            C = A.Multy(B);
            C.Print();
            C = A.Devide(B);
            C.Print();
            Console.WriteLine("Выражения при помощи переопределения операторов:");
            C = A + B;
            C.Print();
            C = A - B;
            C.Print();
            C = A * B;
            C.Print();
            C = A / B;
            C.Print();
            Console.ReadKey();
        }
    }
}
