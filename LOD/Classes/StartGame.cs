using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;

namespace LOD.Classes
{
    class StartGame
    {
        public void Start()
        {
            GameData data = new GameData();

            Console.WriteLine(data.TitleArt);
            Thread.Sleep(5000);
            Console.WriteLine("You have died.");
            Thread.Sleep(1000);
            Console.WriteLine(data.Gameover);
        }
    }
}
