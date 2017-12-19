using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int up_limit = 100;
            int[] arr = new int[up_limit];
            // arr -> {1, 2, 3, ... , 99, 100}
            for (int i = 0; i < arr.Length; i++){
                arr[i] = i + 1;
            }
            // arr -> {0, 2, 3, ... , 99, 100}
            arr[0] = 0;

            for (int num = 2; num <= up_limit; num++){ // 2〜100で順番に割る
                for (int i = num - 1; i < arr.Length; i++){
                    // forループ最初の配列要素に入っているのが、0ならbreak、素数なら飛ばす。
                    if(i == num - 1){
                        if (arr[num - 1] == 0){
                            break;
                        }else{
                            continue;
                        }
                    }
                    // 素数でないなら0を入れておく
                    if(arr[i] % num == 0){
                        arr[i] = 0;
                    }
                }
            }

            // ふるいにかけて出てきた素数表示
            for (int i = 0; i < arr.Length; i++){
                if(arr[i] == 0) { continue; }
                Console.Write(arr[i] + " ");
            }
        }
    }
}
