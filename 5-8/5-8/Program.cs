using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8
{
    class GList<T>
    {
        private T[] ary = new T[3];
        private int index;

        public void SavetoAry(T tData)
        {
            if (index < ary.Length)
            {
                ary[index] = tData;
                index++;
            }
        }

        public void show()
        {
            for (int k = 0; k < ary.Length; k++)
            {
                Console.WriteLine("{0}=>{1}", k, ary[k]);
            }
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            GList<double> myd = new GList<double>();
            myd.SavetoAry(30.5);
            myd.SavetoAry(-25.1209);
            myd.SavetoAry(0.0675);
            myd.SavetoAry(3.0675);  // 放不進
            myd.show();

            GList<string> mys = new GList<string>();
            mys.SavetoAry("abc");
            mys.SavetoAry("ABC");
            mys.SavetoAry("!@#$%^&*()");
            mys.show();

            Dictionary<int, string> intvalue = new Dictionary<int, string>();
            intvalue.Add(5, "five");
            intvalue.Add(7, "seven");
            intvalue.Add(2, "two");
            intvalue.Add(6, "six");

            foreach (KeyValuePair<int, string> kv in intvalue)
            {
                Console.WriteLine("{0}=>{1}", kv.Key, kv.Value);
            }

            Console.Read();
        }
    }
}
