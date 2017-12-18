using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd_min = 1;
            int rnd_max = 1000;
            Random rnd = new Random();
            int num = rnd.Next(rnd_min, rnd_max + 1);

            int x10_num = 0;
            int tmp = num;
            while(true){
                if(tmp / 10 != 0){
                    tmp /= 10;
                    x10_num++;
                }else{
                    break;
                }
            }
            Console.WriteLine(num);
            Console.WriteLine("桁数：" + (x10_num + 1));
        }
    }
}
