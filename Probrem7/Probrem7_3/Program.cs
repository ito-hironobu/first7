using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.Number1 = 8;
            c.Number2 = 9;
            Console.WriteLine("{0} + {1} = {2}", c.Number1, c.Number2, c.Add());
            Console.WriteLine("{0} - {1} = {2}", c.Number1, c.Number2, c.Sub());
        }
    }
}
