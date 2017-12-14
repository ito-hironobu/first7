using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0から100までの数値を入力してください:");
            int num = int.Parse(Console.ReadLine());

            if(num >= 20 && num < 80){
                Console.WriteLine("20以上80未満です。");
            }else if(num >= 0 && num <= 100){
                Console.WriteLine("20未満か80以上です。");
            }else{
                Console.WriteLine("範囲外です。");
            }
        }
    }
}