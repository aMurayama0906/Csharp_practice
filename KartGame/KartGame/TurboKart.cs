using System;
namespace KartGame
{
    //Kartクラスを継承して作る
    public class TurboKart : Kart
    {

        //ブーストするメソッド
        public void Turbo()
        {
            Console.WriteLine("ブースト!");
        }

        //Hornメソッドをオーバーライドする
        public override void Horn()
        {
            Console.WriteLine("ちょめちょめ");
        }

    }

}
