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
            int arr_size = (rnd_max - rnd_min) + 1; // サイズ10
            Random rnd = new Random();

            int[] arr1 = new int[arr_size];
            int[] arr2 = new int[arr_size];
            int[] arr_and = new int[arr_size]; // AND用配列、一旦サイズは10
            int[] arr_or = new int[arr_size]; // OR用配列、一旦サイズは10

            // 配列1に格納&表示
            Console.Write("配列1：");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            // 配列2に格納&表示
            Console.Write("配列2：");
            for (int i = 0; i < arr2.Length; i++){
                arr2[i] = rnd.Next(rnd_min, rnd_max + 1);
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            // ANDの数の格納用配列サイズ算出
            int count_and = 0;
            for (int num = rnd_min; num <= rnd_max; num++){
                bool f1 = false, f2 = false;
                for (int i = 0; i < arr1.Length; i++){
                    if(arr1[i] == num){
                        f1 = true;
                        break;
                    }
                }
                if (!f1) { continue; }

                for (int i = 0; i < arr2.Length; i++){
                    if (arr2[i] == num){
                        f2 = true;
                        break;
                    }
                }
                if (!f2) { continue; }

                arr_and[count_and] = num; // {1, 3, 6, 8, 0, 0, 0, 0, 0, 0}みたいなイメージ
                count_and++;
            }

            // ORの数の格納用配列サイズ算出
            int count_or = 0;
            for (int num = rnd_min; num <= rnd_max; num++){
                bool flag = false;
                for (int i = 0; i < arr1.Length; i++){
                    if (arr1[i] == num){
                        flag = true;
                        arr_or[count_or] = num;
                        count_or++;
                        break;
                    }
                }
                if (flag) { continue; }

                for (int i = 0; i < arr2.Length; i++){
                    if (arr2[i] == num){
                        arr_or[count_or] = num;
                        count_or++;
                        break;
                    }
                }
            }

            // サイズぴったりのAND配列、OR配列を作成して表示
            Console.Write("共通の数：");
            int[] a_and = new int[count_and];
            for (int i = 0; i < count_and; i++){
                a_and[i] = arr_and[i];
                Console.Write(a_and[i] + " ");
            }
            Console.WriteLine();

            Console.Write("どちらか入っている数：");
            int[] a_or = new int[count_or];
            for (int i = 0; i < count_or; i++){
                a_or[i] = arr_or[i];
                Console.Write(a_or[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
