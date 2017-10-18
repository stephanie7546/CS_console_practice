using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        public static void Printout(IEnumerable tarlst)
        {
            int n = 1;
            foreach (Object obj in tarlst)
            {
                Console.WriteLine("第{0}個元素資料內容：{1}", n, obj);
                n++;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ArrayList arylst = new ArrayList();
            arylst.Add("A");
            arylst.Add("B");
            arylst.Add("123");
            arylst.Add("true");

            arylst.AddRange(new string[] { "C", "D" });
            arylst.Insert(2, "X");
            arylst.Add("E");

            Console.WriteLine("1.目前 array list 可存放元素總容量：{0}", arylst.Capacity);
            Console.WriteLine("1.目前 array list 元素總共：{0}", arylst.Count);

            Printout(arylst);

            arylst.Remove("C");
            Printout(arylst);
            arylst.RemoveAt(2);
            Printout(arylst);
            arylst.RemoveRange(2, 3);
            Printout(arylst);
            arylst.Reverse();

            Console.WriteLine("2.目前 array list 可存放元素總容量：{0}", arylst.Capacity);
            Console.WriteLine("2.目前 array list 元素總共：{0}", arylst.Count);

            Printout(arylst);
            arylst.Clear();

            Console.WriteLine("3.目前 array list 可存放元素總容量：{0}", arylst.Capacity);
            Console.WriteLine("3.目前 array list 元素總共：{0}", arylst.Count);

            Console.Read();
        }
    }
}
