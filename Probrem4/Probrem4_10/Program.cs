using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int rnd_max = 100;
            int rnd_min = 1;
            Random rnd = new Random();

            for(int i = 0; i < 5; i++){
                num = rnd.Next(rnd_min, rnd_max + 1);
                Console.WriteLine(num);
            }
        }
    }
}