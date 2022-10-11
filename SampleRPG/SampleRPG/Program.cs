using System;

namespace SampleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            player player = new player("Kenji",556);
            //hpプロパティに代入
            player.Hp -= 70;
            //現在の体力を表示
            Console.WriteLine("HPは" + player.Hp);

        }
    }
}

