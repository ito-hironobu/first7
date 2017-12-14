using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int rnd_max = 100;
            int rnd_min = 1;
            Random rnd = new Random();

            int max = rnd_min; // 生成される最小値を入れておく
            int min = rnd_max; // 生成される最大値を入れておく

            for(int i = 0; i < 5; i++){
                num = rnd.Next(rnd_min, rnd_max + 1);
                Console.WriteLine(num);

                if(num < min){
                    min = num;
                }
                if(num > max){
                    max = num;
                }
            }
            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);
        }
    }
}