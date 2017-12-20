using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_6
{
    public class Fraction
    {
        private int integer; // 整数部分
        private int numerator; // 分子
        private int denominator; // 分母

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
