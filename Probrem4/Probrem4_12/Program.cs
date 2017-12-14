using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int rnd_max = 100;
            int rnd_min = 1;
            Random rnd = new Random();

            int even_num = 0; // 偶数
            int odd_num = 0; // 奇数

            for(int i = 0; i < 5; i++){
                num = rnd.Next(rnd_min, rnd_max + 1);
                Console.WriteLine(num);

                if(num % 2 == 0){
                    even_num++;
                }else{
                    odd_num++;
                }
            }
            Console.WriteLine("偶数の数：" + even_num);
            Console.WriteLine("奇数の数：" + odd_num);
        }
    }
}