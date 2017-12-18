using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoString s = new TwoString();
            s.String1 = "Hello";
            s.String2 = "World";
            Console.WriteLine("一つ目の文字列は" + s.String1);
            Console.WriteLine("二つ目の文字列は" + s.String2);
            Console.WriteLine("二つの文字列を合成したものは" + s.GetConnectedString());
        }
    }
}
