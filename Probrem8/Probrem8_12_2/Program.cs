using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnd_min = 2;
            int rnd_max = 100;
            Random rnd = new Random();
            int num = rnd.Next(rnd_min, rnd_max + 1);
            Console.Write(num + " = ");

            bool flag = true;
            for (int i = 2; i <= num; i++){
                while(true){
                    if(num % i != 0){
                        break;
                    }else{
                        num /= i;
                        if(flag){
                            Console.Write(i);
                            flag = false;
                        }else{
                            Console.Write(" × " + i);
                        }
                    }
                }
            }
        }
    }
}
