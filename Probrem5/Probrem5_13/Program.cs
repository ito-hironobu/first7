using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2次元配列
            //int[,] data = new int[3, 3];

            //int rnd_max = 9;
            //int rnd_min = 0;
            //Random rnd = new Random();

            //for (int i = 0; i < data.GetLength(0); i++)
            //{
            //    for (int j = 0; j < data.GetLength(1); j++)
            //    {
            //        data[i, j] = rnd.Next(rnd_min, rnd_max + 1);
            //        Console.Write(data[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int max = rnd_min;
            //int min = rnd_max;

            //foreach(int i in data){
            //    if(i > max){
            //        max = i;
            //    }
            //    if(i < min){
            //        min = i;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("最大値：" + max);
            //Console.WriteLine("最小値：" + min);

            // 配列の配列
            int[][] data = new int[3][];
            for (int i = 0; i < data.Length; i++){
                data[i] = new int[3];
            }

            int rnd_max = 9;
            int rnd_min = 0;
            Random rnd = new Random();

            for (int i = 0; i < data.Length; i++){
                for (int j = 0; j < data[i].Length; j++){
                    data[i][j] = rnd.Next(rnd_min, rnd_max + 1);
                    Console.Write(data[i][j] + " ");
                }
                Console.WriteLine();
            }

            int max = rnd_min;
            int min = rnd_max;

            // 1.forループで回す
            //for (int i = 0; i < data.Length; i++){
            //    for (int j = 0; j < data[i].Length; j++){
            //        if(data[i][j] > max){
            //            max = data[i][j];
            //        }
            //        if(data[i][j] < min){
            //            min = data[i][j];
            //        }
            //    }
            //}

            // 2.foreachで回す
            foreach(int[] i in data){
                foreach(int j in i){
                    if(j > max){
                        max = j;
                    }
                    if(j < min){
                        min = j;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);
        }
    }
}
