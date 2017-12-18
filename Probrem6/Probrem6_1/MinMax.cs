using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_1
{
    public class MinMax
    {
        public int Max(int a, int b, int c)
        {
            int max = a;
            if(b > max){
                max = b;
            }
            if(c > max){
                max = c;
            }
            return max;
        }
        public int Min(int a, int b, int c){
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;
        }
    }
}
