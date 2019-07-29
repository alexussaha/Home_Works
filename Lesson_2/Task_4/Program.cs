using System;


namespace Task_4
{
    class Program
    {
        static string login = "root";
        static string password = "GeekBrains";
        static bool CheckTheEntrence(string usrlogin, string usrpassword)
        {
            bool log, pas;
            log = String.Equals(usrlogin, login);
            if (log) return pas = String.Equals(usrpassword, password);
            return log;
        }
        static void Main(string[] args)
        {
            
            int i = 0;
            bool right = false;
            do
            {
                string userLogin;
                string userPassword;
                if (i != 0) Console.WriteLine($"У Вас осталось {3-i} попыток.");
                Console.Write("Введите логин: ");
                userLogin = Console.ReadLine();
                Console.Write("Введите пароль: ");
                userPassword = Console.ReadLine();
                right = CheckTheEntrence(userLogin, userPassword);
                i++;

            } while (!(right || i==3));
            if (right == false) Console.WriteLine("Ваши попытки закончились.");
              else Console.WriteLine("Вход выполнен.");
            Console.ReadKey();
        }
    }
}
