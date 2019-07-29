using System;

namespace Task_6
{
    class Program
    {
        static bool IsTheNumberGood(int number)
        {
            int checkNumber = number;
            int sum = 0;
            while (checkNumber != 0)
            {
                sum += checkNumber % 10;
                checkNumber = checkNumber / 10;
            }
            if (number % sum == 0)    return true;
            
            return false;
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for(int i = 1; i<= 1000000000; i++)
            {
                if (IsTheNumberGood(i)) count++;
            }

            DateTime finish = DateTime.Now;
            Console.WriteLine(count);
            Console.WriteLine($"Время: {finish - start}");
            Console.ReadKey();

        }
    }
}
