using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int rnd_max = 10;
            int rnd_min = -10;
            Random rnd = new Random();

            int ct_plus = 0;
            int ct_zero = 0;
            int ct_minus = 0;

            for (int i = 0; i < data.Length; i++){
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(data[i] + " ");
            }

            for (int i = 0; i < data.Length; i++){
                if(data[i] > 0){
                    ct_plus++;
                }else if(data[i] < 0){
                    ct_minus++;
                }else{
                    ct_zero++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("0より大きい数：{0}個", ct_plus);
            Console.WriteLine("0より小さい数：{0}個", ct_minus);
            Console.WriteLine("0の個数：{0}個", ct_zero);
        }
    }
}
