using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num;

            while(true){
                num = rnd.Next(1, 101);
                Console.WriteLine(num);

                if(num % 10 == 0){
                    Console.WriteLine("終了します");
                    break;
                }
            }
        }
    }
}