using System;
using System.Text.RegularExpressions;


namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int chooseTheVariant = int.Parse(Console.ReadLine()); ;
            switch(chooseTheVariant)
            {
                case 1:
                    Login_A usr = new Login_A();
                    do
                    {
                        Console.WriteLine("Введите логин: строка от 2 до 10 символов,\n содержащая только буквы латинского алфавита или цифры,\n при этом цифра не может быть первой");
                        usr.Login(Console.ReadLine());
                        bool testA = usr.IsTheLoginLengthFalse(), testB = usr.TheFistSymbolIsNumber(), testC = usr.IfTheLoginContainsForbiddenSymbols();
                        if (testA) Console.WriteLine("Ошибка. Логин длжен быть длиной от 2 до 10 символов.");
                        if (testB) Console.WriteLine("Ошибка. Цифра не может быть первой.");
                        if (testC) Console.WriteLine("Ошибка. Логин должен состоять только из букв и цифр.");
                    } while (usr.IfTheLoginIsRight());
                    Console.WriteLine("Логин верен.");
                    Console.ReadKey();

                    break;
                case 2:
                    string login;
                    Regex theRoolOfLogin = new Regex(@"^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
                    do
                    {
                        Console.WriteLine("Введите логин: строка от 2 до 10 символов,\n содержащая только буквы латинского алфавита или цифры,\n при этом цифра не может быть первой");
                        login = Console.ReadLine();
                        if (theRoolOfLogin.IsMatch(login)) Console.WriteLine("Логин верен");
                        else Console.WriteLine("В логине ошибка");
                    } while (!theRoolOfLogin.IsMatch(login));
                    Console.ReadKey();
                    break;

                default: Console.WriteLine("Варианта нет");
                    break;
            }
        }   
    }
}
