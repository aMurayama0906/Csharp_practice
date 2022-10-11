using System;

namespace KartGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SkyKart skyKart = new SkyKart();
            TurboKart turboKart = new TurboKart();

            skyKart.Force();
            skyKart.Flying();
            turboKart.Force();
            turboKart.Turbo();
            //Console.WriteLine("Hello World!");
        }
    }
}

