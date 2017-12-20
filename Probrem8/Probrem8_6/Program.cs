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
            int rnd_d_min = 1;
            int rnd_max = 10;

            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            f1.N = rnd.Next(rnd_n_min, rnd_max + 1);
            f1.D = rnd.Next(rnd_d_min, rnd_max + 1);
            f2.N = rnd.Next(rnd_n_min, rnd_max + 1);
            f2.D = rnd.Next(rnd_d_min, rnd_max + 1);

            // 2つの分数の足し算
            Fraction f = AddFraction(f1, f2);

            // 計算結果表示
            Console.WriteLine("{0} + {1} = {2}", f1.GetFracString(), f2.GetFracString(), f.GetFracString());
        }

        static Fraction AddFraction(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.I = f1.I + f2.I; // 整数部分の足し算
            f.N = (f1.N * f2.D) + (f2.N * f1.D); // 通分後の分子の足し算
            f.D = f1.D * f2.D; // 通分後の分母
            f.Band();
            f.About();
            return f;
        }
    }
}
