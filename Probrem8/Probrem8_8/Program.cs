using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd_min = 1;
            int rnd_max = 1000;
            Random rnd = new Random();
            int num = rnd.Next(rnd_min, rnd_max + 1);

            Console.WriteLine(num);
            Console.Write("約数：");

            for (int i = 1; i <= num; i++){
                if(num % i == 0){
                    Console.Write(i + " ");
                }
            }
        }
    }
}
