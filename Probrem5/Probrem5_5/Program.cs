using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int rnd_max = 10;
            int rnd_min = 1;
            Random rnd = new Random();

            string str_3x = "3の倍数：";
            string str_not3x = "3の倍数以外の数：";

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(data[i] + " ");

                if (data[i] % 3 == 0)
                {
                    str_3x += data[i] + " ";
                }
                else
                {
                    str_not3x += data[i] + " ";
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(str_3x);
            Console.WriteLine(str_not3x);
        }
    }
}
