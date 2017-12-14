using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            if(a > 30 && a <= 70){
                Console.WriteLine("30より大きくか70以下です。");
            }
        }
    }
}