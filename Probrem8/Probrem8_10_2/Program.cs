using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数値が30までのトリボナッチ
            int counter = 3;
            int a = 1, b = 1, c = 2;
            int d;
            while (true){
                d = a + b + c;
                if (d > 30)
                {
                    break;
                }
                a = b;
                b = c;
                c = d;
                counter++;
            }

            int[] tribo = new int[counter];
            tribo[0] = 1;
            tribo[1] = 1;
            tribo[2] = 2;
            for (int i = 3; i < tribo.Length; i++){
                tribo[i] = tribo[i - 3] + tribo[i - 2] + tribo[i - 1];
            }

            for (int i = 0; i < tribo.Length; i++){
                Console.Write(tribo[i] + " ");
            }


            // 30番目までのトリボナッチ
            /*
            int[] tribo = new int[30];
            tribo[0] = 1;
            tribo[1] = 1;
            tribo[2] = 2;
            for (int i = 3; i < tribo.Length; i++){
                tribo[i] = tribo[i - 3] + tribo[i - 2] + tribo[i - 1];
            }

            for (int i = 0; i < tribo.Length; i++){
                Console.Write(tribo[i] + " ");
            }
            */
        }
    }
}
