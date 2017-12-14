using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = { 0.2, -5.1, 3.2, 1.8 };

            for (int i = 0; i < d.Length; i++){
                Console.Write("d[{0}]={1} ", i, d[i]);
            }
        }
    }
}
