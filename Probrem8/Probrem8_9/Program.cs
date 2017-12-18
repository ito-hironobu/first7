using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10000以下の完全数：");
            for (int i = 1; i <= 10000; i++){
                int sum = 0;
                for (int j = 1; j <= i / 2; j++){
                    if(i % j == 0){
                        sum += j;
                    }
                }
                if(sum == i){
                    Console.Write(i + " ");
                }
            }
        }
    }
}
