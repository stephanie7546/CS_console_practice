using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7
{
    class Program
    {
        public static void Printout(IEnumerable score)
        {
            foreach (DictionaryEntry s in score)
            {
                Console.WriteLine("{0}=>{1}", s.Key, s.Value);
            }
        }

        static void Main(string[] args)
        {
            string name;
            int score;
            SortedList Sscore = new SortedList();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("請輸入6 - {0}位同學姓名", i+1);
                name = Console.ReadLine();

                if (Sscore.ContainsKey(name) == true)
                {
                    Console.WriteLine("{0} 已存在", name);
                    i--;
                }
                else
                {
                    Console.WriteLine("請輸入成績");
                    score = int.Parse(Console.ReadLine());
                    Sscore.Add(name, score);
                    // Console.WriteLine("{0} => {1}", name, score);
                }
            }

            Printout(Sscore);
            Console.Read();
        }
    }
}
