using System;
namespace 本
{
    public class Book
    {
        //プライベートな変数の宣言
        private string name;
        
        public Book(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}

