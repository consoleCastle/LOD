using System;
using LOD.Classes;
using LOD.Utils;
using System.Collections.Generic;
using System.Text;

namespace LOD.Tools
{
    class PlayRockGame
    {
        public void Play(GameRooms gamerooms, PlayerFlags playerflags)
        {
            RockGame rockGame = new RockGame();
            Console.WriteLine($"There are {rockGame.rockCount} rocks. Do you want to take rocks first?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string userCommand = Console.ReadLine();
            Checker.CheckStatement(userCommand, rockGame);
            while (rockGame.winner == "none")
            {
                if (rockGame.rockCount % 3 == 2)
                {
                    rockGame.PlayerTake("golem", 2);
                    Console.WriteLine("The golem takes 2 rocks.");
                }
                else if (rockGame.rockCount % 3 == 1)
                {
                    rockGame.PlayerTake("golem", 1);
                    Console.WriteLine("The golem takes 1 rock.");
                }
                else
                {
                    Random random = new Random();
                    int choice = random.Next(1, 3);
                    rockGame.PlayerTake("golem", choice);
                    if (choice == 1) Console.WriteLine("The golem takes 1 rock.");
                    if (choice == 2) Console.WriteLine("The golem takes 2 rocks.");
                }
                Console.WriteLine($"There are {rockGame.rockCount} rocks left.");
                if (rockGame.rockCount == 0) break;
                Console.WriteLine("How many rocks will you take now?");
                Console.WriteLine("1. 1 rock");
                Console.WriteLine("2. 2 rocks");
                string newUserCommand = Console.ReadLine();
                Checker.CheckStatement(newUserCommand, rockGame);
            }
            if (rockGame.winner == "golem")
            {
                GameData.CurrentRoom = gamerooms.rock_game_lose;
            }
            if (rockGame.winner == "player")
            {
                playerflags.Rock_Champion = true;
                if (!playerflags.Dins_Fire_Collected)
                {
                    GameData.CurrentRoom = gamerooms.rock_game_win;
                }
                else
                {
                    GameData.CurrentRoom = gamerooms.rock_game_win_again;
                }
                playerflags.Dins_Fire_Collected = true;
            }
        }
        public void PlayTest(GameRooms gamerooms, PlayerFlags playerflags)
        {
            playerflags.Rock_Champion = true;
            if (!playerflags.Dins_Fire_Collected)
            {
                GameData.CurrentRoom = gamerooms.rock_game_win;
            }
            else
            {
                GameData.CurrentRoom = gamerooms.rock_game_win_again;
            }
            playerflags.Dins_Fire_Collected = true;
        }
    }
}
