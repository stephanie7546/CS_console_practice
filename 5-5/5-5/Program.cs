using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
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
            Stack SName = new Stack();
            string[] aryN = { "A", "B", "C", "D", "E" };
            for (int i = 0; i < aryN.Length; i++)
            {
                SName.Push(aryN[i]);
            }
            Console.WriteLine("1.stack 元素共計{0}", SName.Count);
            Printout(SName);

            SName.Pop();
            Console.WriteLine("2.stack 元素共計{0}", SName.Count);
            Printout(SName);

            SName.Push("F");
            Console.WriteLine("3.stack 元素共計{0}", SName.Count);
            Printout(SName);

            SName.Clear();
            Console.WriteLine("4.stack 元素共計{0}", SName.Count);
            Printout(SName);

            Console.Read();

        }
    }
}
