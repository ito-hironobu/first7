using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int rnd_max = 100;
            int rnd_min = 1;
            Random rnd = new Random();

            string str_over = "50以上の数：";
            string str_under = "50未満の数：";

            for(int i = 0; i < data.Length; i++){
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(data[i] + " ");

                if(data[i] >= 50){
                    str_over += data[i] + " ";
                }else{
                    str_under += data[i] + " ";
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(str_over);
            Console.WriteLine(str_under);
        }
    }
}
