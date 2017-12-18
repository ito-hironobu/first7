using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数値が40までのフィボナッチ
            int counter = 2;
            int a = 1, b = 1;
            int c;
            while(true){
                c = a + b;
                if(c > 40){
                    break;
                }
                a = b;
                b = c;
                counter++;
            }

            int[] fibo = new int[counter];
            fibo[0] = 1;
            fibo[1] = 1;
            for (int i = 2; i < fibo.Length; i++){
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }
            for (int i = 0; i < fibo.Length; i++){
                Console.Write(fibo[i] + " ");
            }


            // 40番目までのフィボナッチ
            /*
            int[] fibo = new int[40];
            fibo[0] = 1;
            fibo[1] = 1;
            for (int i = 2; i < fibo.Length; i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }

            for (int i = 0; i < fibo.Length; i++)
            {
                Console.Write(fibo[i] + " ");
            }
            */
        }
    }
}
