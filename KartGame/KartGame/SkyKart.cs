using System;
namespace KartGame
{
    //Kartクラスを継承して作る
    class SkyKart : Kart
    {
        //離陸するメソッド
        public void Flying()
        {
            Console.WriteLine("離陸!");
        }

        //Hornメソッドをオーバーライドする
        public override void Horn()
        {
            Console.WriteLine("ちっちきちー");
        }
    }
}

