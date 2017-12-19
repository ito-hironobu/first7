using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd_min = 1;
            int rnd_max = 10;
            Random rnd = new Random();

            int[] arr1 = new int[10];
            int[] arr2 = new int[10];

            // 配列2に格納&表示
            Console.Write("配列2：");
            for (int i = 0; i < arr2.Length; i++){
                arr2[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            int counter_and = 0;
            int counter_or = 0;
            for (int num = 1; num <= 10; num++){
                bool f1 = false, f2 = false;
                for (int i = 0; i < arr1.Length; i++){
                    if(arr1[i] == num){
                        f1 = true;
                        break;
                    }
                }
                if (!f1) { continue; }

                for (int i = 0; i < arr2.Length; i++){
                    if (arr2[i] == num)
                    {
                        f2 = true;
                        break;
                    }
                }
                if (!f2) { continue; }

                counter_and++;
            }
        }
    }
}
