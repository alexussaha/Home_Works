using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Усов Алксандр
 * 2. Разработать класс Message, содержащий следующие статические методы для обработки
текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.
 * 
 * 
 * 
 * */
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "2. Разработать класс Message, содержащий следующие статические методы для обработки текста:\n а) Вывести только те слова сообщения, которые содержат не более n букв.\n б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.\n в) Найти самое длинное слово сообщения.\n г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.\n Продемонстрируйте работу программы на текстовом файле с вашей программой.";
            Message mess = new Message(text);
            mess.WriteOnlySuitableWords(10);
            Console.WriteLine();
            string newText = mess.RemoveFromTheTextAllWordsEndingOn('ь');
            Console.WriteLine(newText);
            Console.WriteLine(mess.FindTheLongestWord());
            Console.WriteLine(mess.ArrayOfLongestWords());
            Console.ReadKey();
        }
    }
}
