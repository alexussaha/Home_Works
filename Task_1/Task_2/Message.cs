using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Message
    {
        string text;
        public Message(string text)
        {
            this.text = text;
        }
        public void WriteOnlySuitableWords(int n)
        {
           
            char[] div = { ' ', '.', '!', '?', '/', '\'', ':', ';',',' };
            string copyText = text;
            string[] arrayOfWordsFromTheText = copyText.Split(div);
            for (int i = 0; i<arrayOfWordsFromTheText.GetLength(0); i++)
            {
                if (arrayOfWordsFromTheText[i].Length < n && arrayOfWordsFromTheText[i]!= "") Console.WriteLine(arrayOfWordsFromTheText[i]);
            }
        }
        public string RemoveFromTheTextAllWordsEndingOn(char endSymbol)
        {
            char[] div = { ' ', '.', '!', '?', '/', '\'', ':', ';', ',' };
            string copyText = text;
            string[] arrayOfWordsFromTheText = copyText.Split(div);
            List<string> newText = new List<string>();
            foreach (var s in arrayOfWordsFromTheText)
            {
                if (!(s.EndsWith(endSymbol.ToString()))) newText.Add(s);
            }
            string text2 = "";
            foreach (string s in newText)
            {
                text2 += s + " ";
            }
            return text2;
        }

        public string FindTheLongestWord()
        {
            char[] div = { ' ', '.', '!', '?', '/', '\'', ':', ';', ',' };
            string copyText = text;
            string[] arrayOfWordsFromTheText = copyText.Split(div);
            string theLongestWord = "";
            foreach(string s in arrayOfWordsFromTheText)
            {
                if (s.Length > theLongestWord.Length) theLongestWord = s;
            }
            return theLongestWord;
        }

        public StringBuilder ArrayOfLongestWords()
        {
            StringBuilder newtext = new StringBuilder();
            int lengthOfTheLongestWord = 0;
            char[] div = { ' ', '.', '!', '?', '/', '\'', ':', ';', ',' };
            string copyText = text;
            string[] arrayOfWordsFromTheText = copyText.Split(div);
            foreach(string s in arrayOfWordsFromTheText)
            {
                if (s.Length > lengthOfTheLongestWord) lengthOfTheLongestWord = s.Length;
            }
            foreach (var s in arrayOfWordsFromTheText)
            {
                if (s.Length == lengthOfTheLongestWord) newtext.Append(s);
            }
            return newtext;
        }
       
    }
}
