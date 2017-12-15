using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[7];
            int rnd_max = 10;
            int rnd_min = 1;
            Random rnd = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < data.Length; i++){
                for (int j = 0; j < data[i]; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
