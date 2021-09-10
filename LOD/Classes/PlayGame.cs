using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;

namespace LOD.Classes
{
    class PlayGame
    {
        GameData data = new GameData();
        Room current_room {get; set;}
        public void Start()
        {
            Console.WriteLine(data.TitleArt);
            //Thread.Sleep(5000);
            LoadingAnimation loading = new LoadingAnimation();
            loading.Delay = 500;
            Console.WriteLine(data.CurrentRoom.Description);
            string userCommand = Console.ReadLine();
            while (true)
            {
                loading.Run("Loading", sequenceCode: 1);
            }
        }
        public void GameOver()
        {
            Console.WriteLine("You have died.");
            Thread.Sleep(1000);
            Console.WriteLine(data.Gameover);
        }
        
    }
}
