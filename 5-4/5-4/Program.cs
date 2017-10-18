using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4
{
    class Program
    {
        public static void Printout(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write("{0}, ", obj);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Queue QName = new Queue();
            string[] aryN = { "A", "B", "C", "D", "E" };

            for (int i = 0; i < aryN.Length; i++)
            {
                QName.Enqueue(aryN[i]);
            }

            Console.WriteLine("queue 元素總計{0}", QName.Count);
            Printout(QName);

            QName.Dequeue();
            Console.WriteLine("queue 元素總計{0}", QName.Count);
            Printout(QName);
            Console.WriteLine("queue 最前面一個{0}", QName.Peek());

            QName.Enqueue("F");
            Console.WriteLine("queue 元素總計{0}", QName.Count);
            Printout(QName);
            Console.WriteLine("queue 最前面一個{0}", QName.Peek());

            QName.Clear();
            Console.WriteLine("queue 元素總計{0}", QName.Count);
            Printout(QName);

            Console.Read();
        }
    }
}
