using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static public char[] Sort(string s)
        {
            char[] content = s.ToCharArray();
            Array.Sort(content);
            return content;
        }
        static public bool Permutation(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            char[] s1 = Sort(s);
            char[] t1 = Sort(t);
            return s.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(t.Select(Char.ToUpper).OrderBy(x => x)); ;
        }


         static void Main(string[] args)
        {
            string a = "Dacd";
            string b = "badc";
            if (Permutation(a, b)) Console.WriteLine("Перестановка");
            else Console.WriteLine("Не перестановка");
            Console.ReadKey();
        }
    }
}
