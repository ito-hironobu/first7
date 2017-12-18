using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_1
{
    public class Data
    {
        private int number = 0;
        private string comment = "";

        public int Number
        {
            set { number = value; }
            get { return number; }
        }

        public string Comment{
            set { comment = value; }
            get { return comment; }
        }
    }
}
