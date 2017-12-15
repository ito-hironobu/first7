using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Probrem5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2次元配列
            int[,] data = new int[3, 3];

            int rnd_max = 9;
            int rnd_min = 0;
            Random rnd = new Random();

            for (int i = 0; i < data.GetLength(0); i++){
                for (int j = 0; j < data.GetLength(1); j++){
                    data[i, j] = rnd.Next(rnd_min, rnd_max + 1);
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 配列の配列
            //int[][] data = new int[3][];
            //for (int i = 0; i < data.Length; i++){
            //    data[i] = new int[3];
            //}

            //int rnd_max = 9;
            //int rnd_min = 0;
            //Random rnd = new Random();

            //for (int i = 0; i < data.Length; i++){
            //    for (int j = 0; j < data[i].Length; j++){
            //        data[i][j] = rnd.Next(rnd_min, rnd_max + 1);
            //        Console.Write(data[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
