using System;
namespace KartGame
{
    public class Kart
    {
        public int weight; //重量
        public int speed; //速度

        //アクセルをふむメソッド
        public void Force()
        {
            Console.WriteLine("加速 or 減速");
        }

        //クラクションを鳴らすメソッド
        public virtual void Horn()
        {
            Console.WriteLine("ブブー");
        }

    }
}

