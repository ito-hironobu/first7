using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            double a = 4.1, b = 2.3;
            Console.WriteLine(a + " + " + b + " = " + c.Add(a, b));
            Console.WriteLine(a + " - " + b + " = " + c.Sub(a, b));
            Console.WriteLine(a + " * " + b + " = " + c.Mul(a, b));
            Console.WriteLine(a + " / " + b + " = " + c.Div(a, b));
        }
    }
}
