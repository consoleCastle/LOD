using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class RockGame
    {
        public int rockCount { get; set; }
        public string winner { get; set; }
        public bool firstRockTaken { get; set; }
        public RockGame()
        {
            Random random = new Random();
            rockCount = random.Next(20, 30);
            winner = "none";
            firstRockTaken = false;
        }
        public void PlayerTake(string player, int num)
        {
            firstRockTaken = true;
            rockCount -= num;
            if (rockCount <= 0) winner = player;
        }
    }
}
