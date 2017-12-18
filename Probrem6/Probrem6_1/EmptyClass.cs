using System;
namespace Probrem6_1
{
    class Person
    {
        //  名前（フィールド）
        public string name = "";
        //  年齢（フィールド）
        public int age = 0;
        //  情報の表示（メソッド）
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }
        //  情報の設定
        public void SetAgeAndName(string name, int a)
        {
            this.name = name;
            age = a;
        }
    }
}
