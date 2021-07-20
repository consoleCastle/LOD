using System;
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
            Console.WriteLine("You have died.");
            Console.WriteLine(data.Gameover);
        }
    }
}
