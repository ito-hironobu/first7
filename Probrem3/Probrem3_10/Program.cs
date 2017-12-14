using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列１を入力:");
            string str1 = Console.ReadLine();
            Console.Write("文字列２を入力:");
            string str2 = Console.ReadLine();

            if(str1 == str2){
                Console.WriteLine("２つの文字列は等しい");
            }else{
                Console.WriteLine("２つの文字列は等しくない");
            }
        }
    }
}