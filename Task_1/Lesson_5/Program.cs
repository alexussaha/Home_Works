using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
        }
    }
}
