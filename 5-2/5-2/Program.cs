using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    delegate double Delegate1(int d1, int d2);

    class Program
    {
        public static double TriA(int H, int B)
        {
            return (H * B) / 2;
        }

        public static double RecA(int L, int W)
        {
            return L * W;
        }

        public static void GetArea(int x, int y, Delegate1 tDvar)
        {
            double area = tDvar(x, y);
            Console.WriteLine("高：{0}  底：{1}  面積：{2}", x, y, area);
        }

        static void Main(string[] args)
        {
            int d1 = 20, d2 = 10;
            
            Delegate1 Dvar = new Delegate1(TriA);
            Console.WriteLine("1.三角形");
            GetArea(d1, d2, Dvar);

            Console.WriteLine("2.矩形");
            GetArea(d1, d2, new Delegate1(RecA));

            Console.Read();
        }
    }
}
