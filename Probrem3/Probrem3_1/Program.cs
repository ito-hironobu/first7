using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a;
            a = int.Parse(Console.ReadLine());
            if(a == 3){
                Console.WriteLine("3です。");
            }
        }
    }
}