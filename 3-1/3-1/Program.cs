using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lottery = new List<int>();
            int special_num = 0;

            var i =0;
            Random rnd = new Random();
            while (i < 7)
            {
                int rander = rnd.Next(0, 49);
                if (!lottery.Contains(rander+1) && i<6)
                {
                    lottery.Add(rander+1);
                    i++;
                }
                else if (!lottery.Contains(rander+1) && i == 6)
                {
                    special_num = rander+1;
                    i++;
                }
                else { }
            }

            Console.WriteLine("大樂透電腦自動選號：");
            Console.Write("一般號碼：");

            foreach (var j in lottery)
            {
                Console.Write("{0}, ", j);
            }

            Console.WriteLine("特別號：" + special_num);

            Console.ReadKey();
        }
    }
}
