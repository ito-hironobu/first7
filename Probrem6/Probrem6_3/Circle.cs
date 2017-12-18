using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_3
{
    public class Circle
    {
        public double r;

        public double Circumference()
        {
            return 2 * 3.14 * r;
        }

        public double Area()
        {
            return r * r * 3.14;
        }
    }
}
