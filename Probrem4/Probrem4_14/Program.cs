using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd_max = 10;
            int rnd_min = 1;
            Random rnd = new Random();
            int num = rnd.Next(rnd_min, rnd_max + 1);
            string str;

            if(num % 2 == 0){
                str = "★";
            }else{
                str = "☆";
            }

            for(int i = 0; i < num; i++){
                Console.Write(str);
            }
        }
    }
}