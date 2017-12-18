using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_2
{
    public class TwoString
    {
        private string string1;
        private string string2;

        public string String1
        {
            set { string1 = value; }
            get { return string1; }
        }

        public string String2
        {
            set { string2 = value; }
            get { return string2; }
        }

        public string GetConnectedString()
        {
            return string1 + string2;
        }
    }
}
