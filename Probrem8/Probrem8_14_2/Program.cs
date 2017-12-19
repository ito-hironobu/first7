using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int locker_num = 50;
            int student_num = 50;
            int[] arr_locker = new int[locker_num];
            for (int i = 0; i < arr_locker.Length; i++){
                arr_locker[i] = -1;
            }

            for (int num = 1; num <= student_num; num++){
                for (int i = 1; i <= arr_locker.Length; i++){
                    if(i % num == 0){
                        arr_locker[i - 1] *= -1;
                    }
                }
            }

            int count = 0;
            Console.Write("開いている扉の番号：");
            for (int i = 0; i < arr_locker.Length; i++){
                if(arr_locker[i] == 1){
                    count++;
                    Console.Write(i + 1 + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("扉が開いているロッカーの個数は{0}個です。", count);
        }
    }
}
