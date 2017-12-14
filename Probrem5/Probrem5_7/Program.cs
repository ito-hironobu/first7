using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int rnd_max = 10;
            int rnd_min = 1;
            Random rnd = new Random();

            int sum = 0;
            for (int i = 0; i < data.Length; i++){
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                sum += data[i];
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            double mean = (double)sum / data.Length;
            Console.WriteLine("合計値：" + sum);
            Console.WriteLine("平均値：" + mean);
            Console.WriteLine();

            string str_bigger = "平均値より大きい数：";
            string str_smaller = "平均値より小さい数：";
            for (int i = 0; i < data.Length; i++){
                if(data[i] > mean){
                    str_bigger += data[i] + " ";
                }
                if (data[i] < mean)
                {
                    str_smaller += data[i] + " ";
                }
            }
            Console.WriteLine(str_bigger);
            Console.WriteLine(str_smaller);
        }
    }
}
