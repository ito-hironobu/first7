using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd_min = 1;
            int rnd_max = 100;
            Random rnd = new Random();

            int[] array = new int[10];
            Console.WriteLine("（並び替え前）");
            Console.Write("array = [ ");
            for (int i = 0; i < array.Length; i++){
                array[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine();

            int tmp_max; // 最大値
            int tmp_index; // 最大値を格納していたインデックス
            int tmp;
            for (int i = 0; i < array.Length; i++){
                tmp_max = -1;
                tmp_index = -1;
                for (int j = i; j < array.Length; j++){
                    if(array[j] > tmp_max){
                        tmp_max = array[j];
                        tmp_index = j;
                    }
                }

                tmp = array[i];
                array[i] = tmp_max;
                array[tmp_index] = tmp;
            }

            Console.WriteLine("（並び替え後）");
            Console.Write("array = [ ");
            for (int i = 0; i < array.Length; i++){
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
