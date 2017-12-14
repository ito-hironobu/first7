using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("点数(1-100)：");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(score > 100 || score < 0){
                Console.WriteLine("範囲外");
            }else if(score >= 80){
                Console.WriteLine("優");
            }else if(score >= 70){
                Console.WriteLine("良");
            }else if(score >= 60){
                Console.WriteLine("可");
            }else{
                Console.WriteLine("不可");
            }
        }
    }
}