﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int i = 0;
            while(i < num){
                Console.Write("■ ");
                i++;
            }
        }
    }
}