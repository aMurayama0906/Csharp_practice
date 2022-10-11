using System;
namespace SampleRPG
{
    class player
    {
        private string name; //プレイヤの名前
        private int hp;  //プレイヤの体力

        //プレイヤークラスのコンストラクタ
        public player(string name, int hp)
        {
            this.name = name; //名前の初期値を代入
            this.hp = hp; //HPの初期値を代入
        }

        //hpプロパティ
        public int Hp
        {
            set
            {
                this.hp = value;
                if(this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }


        //攻撃メソッド
        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        //防御メソッド
        public void Defence()
        {
            Console.WriteLine(this.name + "は防御した");
        }
     
    }
}

