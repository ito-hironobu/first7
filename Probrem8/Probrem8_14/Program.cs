using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("（1〜10000までの友愛数）");
            for (int i = 1; i < 10000; i++){
                int a = SumOfDivisor(i);
                int b = SumOfDivisor(a);
                if(b == i && a != i && i < a){
                    Console.WriteLine(i + " & " + a);
                }
            }
        }

        static int SumOfDivisor(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++){
                if(num % i == 0){
                    sum += i;
                }
            }
            return sum;
        }
    }
}
