using System;

/*                Усов Александ
1. Написать метод, возвращающий минимальное из трех чисел.
2. Написать метод подсчета количества цифр числа.
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
Достаточно решить 4 задачи. Разбивайте программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы делайте в одном решении.
 
     */

namespace Home_Work
{
    class Program
    {
        #region
        static double Min_Between_Three(double a, double b, double c)
        {
            double min = a;
            if (b < a && b < c) min = b;
            else if (c < b && c < a) min = c;
            return min;
        }
        static void FirstTask()
        {
            double a, b, c;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Минимальное из {a}, {b} и {c}: {Min_Between_Three(a, b, c)}");
    
        }
        #endregion

        #region

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
        static void SecondTask()
        {
            int a;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Колличество цифр в чиле: {CountOfDigits(a)}");
        }

        #endregion

        #region
        static int countTheSum = 0;
        static void FindAGoodNumber(int a)
        {
            if (a % 2 != 0 && a > 0)
            {
                countTheSum = countTheSum + a;
            }
        }
        static void ThirdTask()
        {
            int a;
            do
            {
                Console.WriteLine("Введите число");
                a = Convert.ToInt32(Console.ReadLine());
                FindAGoodNumber(a);
            } while (a != 0);
            Console.WriteLine($"Сумма нечётных положительных чисел равна: {countTheSum}");
            Console.ReadKey();
        }
        #endregion

        #region

        static string login = "root";
        static string password = "GeekBrains";
        static bool CheckTheEntrence(string usrlogin, string usrpassword)
        {
            bool log, pas;
            log = String.Equals(usrlogin, login);
            if (log) return pas = String.Equals(usrpassword, password);
            return log;
        }
        static void FourthTask()
        {

            int i = 0;
            bool right = false;
            do
            {
                string userLogin;
                string userPassword;
                if (i != 0) Console.WriteLine($"У Вас осталось {3 - i} попыток.");
                Console.Write("Введите логин: ");
                userLogin = Console.ReadLine();
                Console.Write("Введите пароль: ");
                userPassword = Console.ReadLine();
                right = CheckTheEntrence(userLogin, userPassword);
                i++;

            } while (!(right || i == 3));
            if (right == false) Console.WriteLine("Ваши попытки закончились.");
            else Console.WriteLine("Вход выполнен.");
            
        }

        #endregion

        #region

        static string BodyMassIndex(double weight, double height)
        {
            string msg;
            double imb
;
            imb = weight / Math.Pow(height / 100, 2);
            if (imb < 18.5) msg = $"Вам нужно набрать {(18.5 * Math.Pow(height / 100, 2)) - weight:F2} кг.";
            else if (imb > 25) msg = $"Вам нужно сбросить {weight - (25 * Math.Pow(height / 100, 2)):F2} кг.";
            else msg = "Всё в норме";

            return msg;
        }

        static void FifthTask()
        {
            double weight, height;
            Console.WriteLine("Введите вес");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(BodyMassIndex(weight, height));


        }

        #endregion

        #region

        static bool IsTheNumberGood(int number)
        {
            int checkNumber = number;
            int sum = 0;
            while (checkNumber != 0)
            {
                sum += checkNumber % 10;
                checkNumber = checkNumber / 10;
            }
            if (number % sum == 0) return true;

            return false;
        }
        static void SixthTask()
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (IsTheNumberGood(i)) count++;
            }

            DateTime finish = DateTime.Now;
            Console.WriteLine(count);
            Console.WriteLine($"Время: {finish - start}");
          

        }

        #endregion

        #region

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
        static void SeventhTask()
        {
            int a, b, s;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            RecOut(a, b);
            s = SumOfNum(a, b);
            Console.WriteLine();
            Console.WriteLine($"Сумма от {a} до {b} равна {s}");
         

        }

        #endregion




        static void Main(string[] args)
        {
            int userChoose;
            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Введите число соответствующее номеру домашнего задания или введите ноль для выхода из программы.\n 1 - минимальное из трёх цифр;\n 2 - подсчёт колличества цифр в числе;\n 3 - Сумма ввсех нечётных положительных чисел;\n 4 - логин и пароль;\n 5 - ИМТ;\n 6 - Подсчёт хороших чисел;\n 7 - Рекурсивные методы;\n 0 - выход.");
                userChoose = Convert.ToInt32(Console.ReadLine());
                switch (userChoose)
                {
                    case 0: exit = true;
                        break;
                    case 1:
                        FirstTask();
                        break;
                    case 2:
                        SecondTask();
                        break;
                    case 3:
                        ThirdTask();
                        break;
                    case 4:
                        FourthTask();
                        break;
                    case 5:
                        FifthTask();
                        break;
                    case 6:
                        SixthTask();
                        break;
                    case 7:
                        SeventhTask();
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное число, попробуйте ещё раз.");
                        break;
                }
            }
        }
    }
}
