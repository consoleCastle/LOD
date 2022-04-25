using System;
using System.Threading;
using LOD.Tools;
using LOD.Utils;

namespace LOD.Classes
{
    class PlayGame
    {
        private AsciiArt art;
        private Typewriter typewriter;
        private GameRooms gameRooms;
        private PlayerFlags playerFlags;
        private EndType newEnd;

        public void Start()
        {
            InitializeGame();
            StartScreen();
            Exposition();

            while (!newEnd.IsGameover)
            {
                Console.WriteLine(GameData.CurrentRoom.Description);
                Console.WriteLine("");
                GameData.CurrentRoom = GameData.CurrentRoom.ShowMenu(GameData.CurrentRoom.Description, GameData.CurrentRoom.Options);

                Checker.CheckRoom(playerFlags, newEnd, gameRooms);
                Checker.CheckFlags(playerFlags, gameRooms);
                Checker.CheckRoom(playerFlags, newEnd, gameRooms);
                if (IsDead(playerFlags))
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = GameData.CurrentRoom.Description;
                }
            }

            End(newEnd);
        }

        private void InitializeGame()
        {
            art = new AsciiArt();
            typewriter = new Typewriter();
            gameRooms = new GameRooms();
            playerFlags = new PlayerFlags();
            playerFlags.Reset();
            newEnd = new EndType();

            Console.Clear();

            GameData.CurrentRoom = gameRooms.mountain_top;
        }

        private void StartScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            typewriter.GiveMeSpace();
            Console.WriteLine(art.TitleArt);
            typewriter.GiveMeSpace();
            Console.WriteLine("Press ENTER to begin...");

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
        }

        private void Exposition()
        {
            int fastSpeed = (int)Typewriter.Speed.fast;
            typewriter.Type(art.Exposition, fastSpeed);
            typewriter.GiveMeSpace();

            Console.WriteLine("Press ENTER to proceed to the mountain top...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        public bool IsDead(PlayerFlags playerFlags)
        {
            if (GameData.CurrentRoom.Name == "dark_woods" && !playerFlags.Slightly_JiuJitsu_Proficient)
            {
                ShiaScene shiaScene = new ShiaScene();
                GameData.CurrentRoom.Description = shiaScene.Defeat();
                return true;
            }
            if (GameData.CurrentRoom.Name == "skeleton_room" && !playerFlags.Dins_Fire_Collected)
            {
                GameData.CurrentRoom.Description = RoomDescriptions.FallDeathMsg;
                return true;
            }
            if (GameData.CurrentRoom.Name == "shelobs_lair" && !playerFlags.Farores_Wind_Collected)
            {
                return true;
            }
            if (GameData.CurrentRoom.Name == "joke_fail")
            {
                return true;
            }
            if (GameData.CurrentRoom.Name == "throne_room")
            {
                string deathMsg = "You guessed wrong! King Dallen rips your skull out and drinks your brain.";
                GameData.CurrentRoom.Description = deathMsg;
                return true;
            }
            if (GameData.CurrentRoom.Name == "open_door")
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