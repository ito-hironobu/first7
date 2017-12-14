using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            int rnd_max = 10;
            int rnd_min = 1;
            Random rnd = new Random();

            for (int i = 0; i < a.Length; i++){
                a[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write("a[{0}]={1} ", i, a[i]);
            }
        }
    }
}
