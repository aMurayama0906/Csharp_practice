using System;

namespace _4ple
{
    class Program
    {
        //引数に商品名を受け取り、
        //商品名に応じた値段を表示するメソッド
        static void Shop(string itemname)
        {
            Console.WriteLine("いらっしゃいませ!");
            int price = 0;

            if(itemname == "薬草"){
                Console.WriteLine(itemname + "は100円です");
                price = 100;
            }
            else if(itemname == "ハンマー"){
                Console.WriteLine(itemname + "は1200円です");
                price = 1200;
            }
            else
            {
                Console.WriteLine("売り切れです");
                price = 0;
            }
        }

        static void Main(string[] args)
        {
            int money = 3700;
            Console.WriteLine("所持金は" + money + "円です");
            Shop("ハンマー");
            new money -= price;
            Console.WriteLine("所持金は" + money + "円です");
        }
    }
}

