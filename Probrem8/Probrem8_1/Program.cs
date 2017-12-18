using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int a = 1; a <= 100; a++){
                int A = a * a;
                for (int b = 1; b <= 100; b++){
                    int B = b * b;
                    for (int c = 1; c <= 100; c++){
                        if(c * c == A + B){
                            Console.WriteLine("a={0},b={1},c={2}", a, b, c);
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine("組み合わせの個数：" + counter);
        }
    }
}
