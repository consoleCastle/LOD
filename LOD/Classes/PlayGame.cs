using System;
using System.Threading;
using LOD.Tools;
using LOD.Utils;

namespace LOD.Classes
{
    class PlayGame
    {
        AsciiArt art = new AsciiArt();
        Typewriter typewriter = new Typewriter();
        public void Start()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            typewriter.GiveMeSpace();
            Console.WriteLine(art.TitleArt);
            typewriter.GiveMeSpace();

            PlayerFlags playerFlags = new PlayerFlags();
            playerFlags.Reset();
            EndType newEnd = new EndType();

            Console.WriteLine("Press ENTER to begin...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int fastSpeed = (int)Typewriter.Speed.fast;

            typewriter.Type(art.Exposition, fastSpeed);
            typewriter.GiveMeSpace();

            Console.WriteLine("Press ENTER to proceed to the mountain top...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            GameRooms gamerooms = new GameRooms();
            GameData.CurrentRoom = gamerooms.mountain_top;
            while (!newEnd.IsGameover)
            {
                Console.WriteLine(GameData.CurrentRoom.Description);
                Console.WriteLine("");
                GameData.CurrentRoom = GameData.CurrentRoom.ShowMenu(GameData.CurrentRoom.Description, GameData.CurrentRoom.Options);

                Checker.CheckRoom(playerFlags, newEnd, gamerooms);
                Checker.CheckFlags(playerFlags, gamerooms);
                Checker.CheckRoom(playerFlags, newEnd, gamerooms);
                if (IsDead(playerFlags))
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = GameData.CurrentRoom.Description;
                }
            }

            End(newEnd);
        }

        public bool IsDead(PlayerFlags playerFlags)
        {
            if (GameData.CurrentRoom.Name == "dark_woods" && !playerFlags.Slightly_JiuJitsu_Proficient)
            {
                ShiaScene shiaScene = new ShiaScene();
                GameData.CurrentRoom.Description = "Short defeat for testing";
                //GameData.CurrentRoom.Description = shiaScene.Defeat();
                return true;
            }
            if (GameData.CurrentRoom.Name == "skeleton_room" && !playerFlags.Dins_Fire_Collected)
            {
                string deathMsg = "You step into the darkness and immediately find yourself falling into a void of freezing darkness. You are impaled on spikes at the bottom of a pitch black chasm.";
                GameData.CurrentRoom.Description = deathMsg;
                return true;
            }
            if (GameData.CurrentRoom.Name == "spider_room" && !playerFlags.Farores_Wind_Collected)
            {
                return true;
            }
            return false;
        }

        public void End(EndType endType)
        {
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            typewriter.Type(endType.CauseMessage, moderateSpeed);
            typewriter.GiveMeSpace();

            if (!endType.IsGoodEnding)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(art.GameoverArt);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(art.VictoryArt);
            }

            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(5000);
            typewriter.GiveMeSpace();
            Console.WriteLine("Would you like to play again? Respond with YES or NO.");
            typewriter.GiveMeSpace();
            string UserResponse = Console.ReadLine().ToLower();
            if ((UserResponse == "yes") || (UserResponse == "y"))
            {
                Start();
            }
            else
            {
                ThanksForPlaying();
            }
        }

        public void ThanksForPlaying()
        {
            Console.WriteLine("Thanks for playing!!!");
        }

    }
}