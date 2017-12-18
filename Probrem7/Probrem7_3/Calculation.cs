using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_3
{
    public class Calculation
    {
        private int number1;
        private int number2;

        public int Number1
        {
            set { number1 = value; }
            get { return number1; }
        }

        public int Number2
        {
            set { number2 = value; }
            get { return number2; }
        }

        public int Add()
        {
            return number1 + number2;
        }

        public int Sub()
        {
            return number1 - number2;
        }
    }
}
