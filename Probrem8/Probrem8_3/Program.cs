using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0以上の整数を入力：");
            ulong num = ulong.Parse(Console.ReadLine());

            ulong factorial_num = 1;
            if(num > 0){
                for (ulong i = num; i > 0; i--){
                    factorial_num *= i;
                }
                Console.WriteLine(num + "の階乗 = " + factorial_num);
            }else if(num == 0){
                Console.WriteLine(num + "の階乗 = " + factorial_num);
            }else{
                Console.WriteLine("0以上の整数を入力してください");
            }
        }
    }
}
