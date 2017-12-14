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
            int[] data = new int[10];
            int rnd_max = 100;
            int rnd_min = 1;
            Random rnd = new Random();

            string str_evn = "偶数：";
            string str_odd = "奇数：";

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(data[i] + " ");

                if(data[i] % 2 == 0){
                    str_evn += data[i] + " ";
                }else{
                    str_odd += data[i] + " ";
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(str_evn);
            Console.WriteLine(str_odd);
        }
    }
}
