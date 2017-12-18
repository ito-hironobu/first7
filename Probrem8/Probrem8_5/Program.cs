using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++){
                if(i % 3 == 0 || i % 10 == 3 || (i / 10) % 10 == 3){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
