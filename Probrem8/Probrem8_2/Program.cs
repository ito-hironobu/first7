﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int a = 1; a <= 100; a++){
                for (int b = a; b <= 100; b++){
                    for (int c = 1; c <= 100; c++){
                        if(c * c == a * a + b * b){
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
