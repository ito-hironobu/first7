﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a={0} b={1}", a, b);

            if(a == b){
                Console.WriteLine("aはbと等しい");
            }else if(a > b){
                Console.WriteLine("aはbよりも大きい");
            }else{
                Console.WriteLine("aはbよりも小さい");
            }
        }
    }
}