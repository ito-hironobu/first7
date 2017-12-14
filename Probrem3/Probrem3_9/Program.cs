using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力:");
            string str = Console.ReadLine();
            if(str == "abc"){
                Console.WriteLine("abcです。");
            }else{
                Console.WriteLine("abcではありません。");
            }
        }
    }
}