using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a、bに1から10までの数値を入力してください。");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if((a + 9) / 10 == 1 && (b + 9) / 10 == 1){
                if(a > b){
                    Console.Write("aの方が大きいです。");
                }else if(b > a){
                    Console.Write("bの方が大きいです。");
                }else{
                    Console.Write("等しいです。");
                }
            }else{
                Console.WriteLine("範囲外です。");
            }
        }
    }
}