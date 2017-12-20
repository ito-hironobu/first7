using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_6
{
    public class Fraction
    {
        private int integer = 0; // 整数部分
        private int numerator = 0; // 分子
        private int denominator; // 分母

        public string GetFracString()
        {
            string f_str = "";
            if (integer == 0)
            { // 整数部分が0
                if (numerator == 0)
                { // 分数部分なし
                    f_str += integer; // 0代入
                }
                else
                { // 分数部分あり
                    f_str += numerator + "/" + denominator; // 例）1/3代入
                }
            }
            else
            { // 整数部分あり
                f_str += integer; // 整数部分代入
                if (numerator != 0)
                { // 分数部分あり
                    f_str += "(" + numerator + "/" + denominator + ")"; // 例）(1/3)追加代入
                }
            }
            return f_str;
        }

        // 約分
        public void About()
        {
            for (int num = 2; num <= denominator; num++)
            {
                while (true)
                {
                    if (numerator % num == 0 && denominator % num == 0)
                    {
                        numerator /= num;
                        denominator /= num;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        // 帯分数化
        public void Band()
        {
            integer += numerator / denominator; // 整数部分
            numerator %= denominator; // 小数部分
        }

        public int I
        {
            set { integer = value; }
            get { return integer; }
        }

        public int N
        {
            set { numerator = value; }
            get { return numerator; }
        }

        public int D
        {
            set { denominator = value; }
            get { return denominator; }
        }
    }
}
