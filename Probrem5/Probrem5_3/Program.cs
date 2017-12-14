using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int rnd_max = 100;
            int rnd_min = 1;
            Random rnd = new Random();

            string str_evn = "偶数：";
            string str_odd = "奇数：";

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(a[i] + " ");

                if(a[i] % 2 == 0){
                    str_evn += a[i] + " ";
                }else{
                    str_odd += a[i] + " ";
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(str_evn);
            Console.WriteLine(str_odd);
        }
    }
}
