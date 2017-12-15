using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int rnd_max = 100;
            int rnd_min = 1;
            Random rnd = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            string str_0_60 = "0以上60未満：";
            string str_60_80 = "60以上80未満：";
            string str_80_100 = "80以上：";
            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] < 60){
                    str_0_60 += data[i] + " ";
                }else if(data[i] < 80){
                    str_60_80 += data[i] + " ";
                }else{
                    str_80_100 += data[i] + " ";
                }
            }

            Console.WriteLine(str_0_60);
            Console.WriteLine(str_60_80);
            Console.WriteLine(str_80_100);
        }
    }
}
