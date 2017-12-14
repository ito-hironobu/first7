using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください:");
            int num = int.Parse(Console.ReadLine());

            if(num > 0){
                Console.WriteLine("正の値です。");
            }else if(num < 0){
                Console.WriteLine("負の値です。");
            }else{
                Console.WriteLine("0です。");
            }
        }
    }
}