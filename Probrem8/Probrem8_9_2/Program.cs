using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd_min = 1;
            int rnd_max = 100;
            Random rnd = new Random();

            int[] data = new int[10];
            for (int i = 0; i < data.Length; i++){
                data[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            // 偶数配列、奇数配列のサイズ計算
            int size_evn = 0, size_odd = 0;
            for (int i = 0; i < data.Length; i++){
                if (data[i] % 2 == 0)
                {
                    size_evn++;
                }
                else
                {
                    size_odd++;
                }
            }

            int[] arr_evn = new int[size_evn];
            int[] arr_odd = new int[size_odd];
            int index_evn = 0;
            int index_odd = 0;
            // 偶数配列、奇数配列の作成
            for (int i = 0; i < data.Length; i++){
                if(data[i] % 2 == 0){
                    arr_evn[index_evn] = data[i];
                    index_evn++;
                }else{
                    arr_odd[index_odd] = data[i];
                    index_odd++;
                }
            }

            // 偶数配列の中身表示
            Console.Write("偶数：");
            for (int i = 0; i < arr_evn.Length; i++){
                Console.Write(arr_evn[i] + " ");
            }
            Console.WriteLine();

            // 奇数配列の中身表示
            Console.Write("奇数：");
            for (int i = 0; i < arr_odd.Length; i++){
                Console.Write(arr_odd[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
