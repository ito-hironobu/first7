using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10〜35)：");
            int temperature = int.Parse(Console.ReadLine());

            if(temperature < -10 || temperature > 35){
                Console.Write("適切な値を入力してください。");
            }else{
                Console.WriteLine("摂氏{0}度", temperature);
                Console.WriteLine();

                if(temperature >= 30){
                    Console.WriteLine("真夏日です。");
                }else if(temperature >= 25){
                    Console.WriteLine("夏日です。");
                }else if(temperature >= 0){
                    Console.WriteLine();
                }else{
                    Console.WriteLine("真冬日です。");
                }
            }
        }
    }
}