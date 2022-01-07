using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;
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

            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
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

                CheckRoom(playerFlags, newEnd);
                CheckFlags(playerFlags, newEnd, gamerooms);
                if (IsDead(playerFlags))
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = GameData.CurrentRoom.Description;
                }
            }

            End(newEnd);
        }
        public void CheckStatement(PlayerFlags playerFlags, string userCommand)
        {
            switch (userCommand)
            {
                case "Menu":
                    //TODO make the menu come up
                    break;
                default:
                    if (!GameData.CurrentRoom.Choices.ContainsKey(userCommand))
                    {
                        Console.WriteLine("That is not a valid choice");
                        break;
                    }
                    GameData.CurrentRoom = GameData.CurrentRoom.Choices[userCommand];
                    break;
            }
        }
        public void CheckRoom(PlayerFlags playerflags, EndType newEnd)
        {
            switch(GameData.CurrentRoom.Name)
            {
                case "open_door":
                    newEnd.IsGameover = true;
                    newEnd.IsGoodEnding = true;
                    break;
                case "dojo":
                    playerflags.Slightly_JiuJitsu_Proficient = true;
                    break;
                case "dark_woods":
                    if (playerflags.Slightly_JiuJitsu_Proficient)
                    {
                        playerflags.Shia_Defeated = true;
                        playerflags.Farores_Wind_Collected = true;
                    }
                    break;
            }
        }
        public void CheckFlags(PlayerFlags playerFlags, EndType endType, GameRooms gamerooms)
        {
            if (playerFlags.Three_Stones_Collected)
            {
                gamerooms.temple_door.Choices.Add("3", gamerooms.open_door);
            }
            if (playerFlags.Shia_Defeated)
            {
                gamerooms.forest_entrance.Description = "You have entered a lush and peaceful forest. The evil has been purged and the trees sigh in relief. You can see a tree village deeper in the forest. You also see a path leading back up the mountain.";
                gamerooms.forest_village.Description = "A peaceful village of forest elves lives in the trees! Their elder approaches you: ‘Thank you for saving our village traveler! You are always welcome here.";
                
                gamerooms.forest_village.Choices.Clear();
                Array.Clear(gamerooms.forest_village.Options, 0, gamerooms.forest_village.Options.Length);
                gamerooms.forest_village.Choices.Add("1", gamerooms.forest_entrance);
                gamerooms.forest_village.Options[0] = "Go back to the forest entrance";
                gamerooms.forest_village.Choices.Add("2", gamerooms.dojo);
                gamerooms.forest_village.Options[1] = "Go into the dojo";

                gamerooms.dojo.Choices.Clear();
                Array.Clear(gamerooms.dojo.Options, 0, gamerooms.dojo.Options.Length);
                gamerooms.dojo.Choices.Add("1", gamerooms.forest_village);
                gamerooms.dojo.Options[0] = "Go back to the village";
                gamerooms.dojo.Choices.Add("2", gamerooms.open_mind_room);
                gamerooms.dojo.Options[1] = "Meditate for an open mind";
            }
            if (playerFlags.Slightly_JiuJitsu_Proficient)
            {
                gamerooms.dojo.Description = "You enter the school. There are many students in white uniforms punching logs and throwing rocks. The school leader approaches you: ‘IF YOU CAN DODGE A ROCK, YOU CAN BODY SLAM A MONSTER!’ She hurls a rock at you but you barely get out of the way in time. ‘You have learned much, young grasshopper. You remind me of another student I once had… he had incredible power. I accidentally called him by the wrong name once and he went wild with rage!";
            }
            if (GameData.CurrentRoom.Name == "dark_woods" && playerFlags.Slightly_JiuJitsu_Proficient)
            {
                ShiaScene shiaScene = new ShiaScene();
                //gamerooms.dark_woods.Description = "Short victory for testing";
                gamerooms.dark_woods.Description = shiaScene.Victory();
            }
            if (playerFlags.Open_Mind)
            {
                gamerooms.open_mind_room.Description = "“You already know the way, now go punch something.";
            }
        }
        public Boolean IsDead(PlayerFlags playerFlags)
        {
            if (GameData.CurrentRoom.Name == "dark_woods" && !playerFlags.Slightly_JiuJitsu_Proficient)
            {
                ShiaScene shiaScene = new ShiaScene();
                //GameData.CurrentRoom.Description = "Short defeat for testing";
                GameData.CurrentRoom.Description = shiaScene.Defeat();
                return true;
            }
            return false;
        }

        public void ThanksForPlaying()
        {
            Console.WriteLine("Thanks for playing!!!");
        }
        public void End(EndType endType)
        {
            Console.WriteLine(endType.CauseMessage);
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

    }
}