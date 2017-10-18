using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    interface IExchange {
        double Rate { get; }
        void Convert();
    }

    class UStoNT : IExchange {
        public double Rate { get { return 29.9; } }
        public void Convert() {
            Console.Write("請輸入要兌換的美元：");
            double USd = float.Parse(Console.ReadLine());
            double NTd = USd * Rate;
            Console.WriteLine("美元 {0} 元, 可兌換台幣 {1} 元", USd, NTd.ToString("#.#"));
        }
    }

    class JPtoNT : IExchange {
        public double Rate { get { return 0.375; } }
        public void Convert (){ 
            Console.Write("請輸入要兌換的日幣：");
            double JPd = float.Parse(Console.ReadLine());
            double NTd = JPd * Rate;
            Console.WriteLine("日幣 {0} 元, 可兌換台幣 {1} 元", JPd, NTd.ToString("#.#"));
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            IExchange change;
            UStoNT cashUS = new UStoNT();
            JPtoNT cashJP = new JPtoNT();

            while (true) {
                Console.Write("選擇要兌換台幣的外幣? (1.美元 2.日幣 3.離開)：");
                int item = int.Parse(Console.ReadLine());
                if (item == 1)
                {
                    change = cashUS;
                }
                else if (item == 2)
                {
                    change = cashJP;
                }
                else
                {
                    break;
                }

                change.Convert();
                Console.WriteLine();
            }
                        
        }
    }
}
