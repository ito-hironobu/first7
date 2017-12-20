using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rnd_n_min = 1;
            int rnd_d_min = 2;
            int rnd_max = 10;

            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            f1.N = rnd.Next(rnd_n_min, rnd_max + 1);
            f1.D = rnd.Next(rnd_d_min, rnd_max + 1);
            f2.N = rnd.Next(rnd_n_min, rnd_max + 1);
            f2.D = rnd.Next(rnd_d_min, rnd_max + 1);

            Fraction f = AddFraction(f1, f2);

            // 計算結果表示
            Console.Write("{0}/{1} + {2}/{3} = ", f1.N, f1.D, f2.N, f2.D);
            if(f.I == 0){ // 整数部分が0
                if(f.N == 0){ // 分数部分なし
                    Console.WriteLine(f.I); // 表示）0
                }else{ // 分数部分あり
                    Console.WriteLine(f.N + "/" + f.D); // 表示例）1/3
                }
            }else{ // 整数部分あり
                Console.Write(f.I); // 整数部分表示
                if(f.N != 0){ // 分数部分あり
                    Console.WriteLine("+({0}/{1})", f.N, f.D); // 表示例）1+(1/3)
                }
            }
        }

        static Fraction AddFraction(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.N = (f1.N * f2.D) + (f2.N * f1.D); // 通分後の分子の足し算
            f.D = f1.D * f2.D; // 通分後の分母
            // 約分と帯分数化したものを返す
            return AboutAndBand(f);
        }

        static Fraction AboutAndBand(Fraction f)
        {
            f.I = f.N / f.D; // 整数部分
            f.N %= f.D; // 小数部分
            if (f.N == 0) { return f; } // fが整数になる（分子が0）ならリターン

            // 約分処理
            for (int num = 2; num <= f.D; num++){
                while(true){
                    if (f.N % num == 0 && f.D % num == 0){
                        f.N /= num;
                        f.D /= num;
                    }else{
                        break;
                    }
                }
            }
            return f;
        }
    }
}
