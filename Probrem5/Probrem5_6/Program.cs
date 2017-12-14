using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int rnd_max = 10;
            int rnd_min = 1;
            Random rnd = new Random();

            int max = rnd_min;
            int min = rnd_max;
            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                sum += data[i];
                Console.Write(data[i] + " ");

                if(data[i] > max){
                    max = data[i];
                }
                if(data[i] < min){
                    min = data[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);
            double mean = (double)sum / data.Length;
            Console.WriteLine("平均値：" + mean);
        }
    }
}
