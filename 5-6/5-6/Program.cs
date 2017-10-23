using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6
{
    class Program
    {
        public static void Printout(IEnumerable myHash)
        {
            foreach (DictionaryEntry h in myHash)
            {
                Console.WriteLine("{0}=>{1}", h.Key, h.Value);
            }
        }

        static void Main(string[] args)
        {
            int score;
            string name;
            Hashtable HScore = new Hashtable();

            HScore.Add("Wang", 90);
            HScore.Add("Whang", 80);
            HScore.Add("Chang", 85);
            HScore.Add("Lin", 60);
            Console.WriteLine("1. 原始資料：");
            Printout(HScore);

            Console.WriteLine("2. 請輸入新增姓名：");
            name = Console.ReadLine();

            while (name != "exit")
            {
                if (HScore.ContainsKey(name) == true)
                {
                    Console.WriteLine("{0}->{1}已存在", name, HScore[name]);
                }
                else
                {
                    Console.WriteLine("請輸入成績");
                    score = int.Parse(Console.ReadLine());
                    HScore.Add(name, score);
                    Console.WriteLine("成績：");
                }

                Printout(HScore);

                Console.WriteLine("3. 請輸入刪除姓名：");
                name = Console.ReadLine();

                if (HScore.ContainsKey(name) == true)
                {
                    HScore.Remove(name);
                    Console.WriteLine("{0} 已刪除", name);
                }
                else
                {
                    Console.WriteLine("{0} 本就不存在", name);
                }

                Printout(HScore);

                Console.WriteLine("2. 請輸入新增姓名或exit離開：");
                name = Console.ReadLine();
            }
            
        }
    }
}
