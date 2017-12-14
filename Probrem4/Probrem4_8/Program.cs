using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while(true){
                Console.Write("0以上の数値を入力してください:");
                num = int.Parse(Console.ReadLine());

                if(num < 0){
                    Console.WriteLine("終了します");
                    break;
                }
                Console.WriteLine(num);
            }
        }
    }
}