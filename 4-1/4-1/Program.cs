using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        class CD
        {
            public virtual void play()
            {
                Console.WriteLine("現在播放的是音樂CD");
            }

            public void leave()
            {
                Console.WriteLine("要結束時，請按q或Q離開...");
            }
        }

        class DVD : CD
        {
            public override void play()
            {
                Console.WriteLine("現在播放的是影片DVD");
            }
        }



        static void Main(string[] args)
        {

            bool a = true;
            while (a)
            {
                Console.WriteLine("\n請輸入放入的光碟 (CD或DVD)：");

                string keyin = Console.ReadLine();
                CD cd;


                if (keyin.Equals("q") || keyin.Equals("Q"))
                {
                    a = false;
                }
                else if (keyin.Equals("cd") || keyin.Equals("CD"))
                {
                    cd = new CD();
                    cd.play();
                }
                else if (keyin.Equals("dvd") || keyin.Equals("DVD"))
                {
                    cd = new DVD();
                    cd.play();
                }
                else {
                    cd = new CD();
                    cd.leave();
                }

            }

        }
    }
}
