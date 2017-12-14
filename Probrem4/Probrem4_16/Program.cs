using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_16
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++){
                for(int j = 1; j <= 9; j++){
                    Console.Write("{0}*{1}={2} ", j, i, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}