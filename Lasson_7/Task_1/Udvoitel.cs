using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Udvoitel
    {
        int current;

        int number;

        List<int> list;
        public Udvoitel(int number)
        {
            this.number = number;
            current = 1;
            list = new List<int>();
        }

        public void Plus()
        {
            current++;
            list.Add(current);
        }

        public void Multi()
        {
            current *= 2;
            list.Add(current);
        }

        public void Reset()
        {
            current = 1;
            list.Add(current);
        }

        public int Current
        {
            get { return current; }
        }

        public int Number => number;

        public void Back()
        {
            if (list.Count >= 2){
                list.RemoveAt(list.Count - 1);
                current = list.Last();
            }
        }

    }
}
