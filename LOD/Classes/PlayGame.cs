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

                CheckRoom(playerFlags, newEnd, gamerooms);
                CheckFlags(playerFlags, newEnd, gamerooms);
                CheckRoom(playerFlags, newEnd, gamerooms);
                if (IsDead(playerFlags))
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = GameData.CurrentRoom.Description;
                }
            }

            End(newEnd);
        }
        public void CheckStatement(string userCommand)
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
        public void CheckStatement(string userCommand, RockGame rockGame)
        {
            if (!rockGame.firstRockTaken)
            {
                switch (userCommand)
                {
                    case "1":
                        Console.WriteLine("How many rocks will you take?");
                        Console.WriteLine("1. 1");
                        Console.WriteLine("2. 2");
                        rockGame.firstRockTaken = true;
                        string newUserCommand = Console.ReadLine();
                        CheckStatement(newUserCommand, rockGame);
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("That is not a valid choice.");
                        string newNewUserCommand = Console.ReadLine();
                        CheckStatement(newNewUserCommand, rockGame);
                        break;
                }
            }
            switch (userCommand)
            {
                case "1":
                    rockGame.PlayerTake("player", 1);
                    break;
                case "2":
                    rockGame.PlayerTake("player", 2);
                    break;
                default:
                    Console.WriteLine("That is not a valid choice.");
                    string newUserCommand = Console.ReadLine();
                    CheckStatement(newUserCommand, rockGame);
                    break;
            }
        }
        public void CheckRoom(PlayerFlags playerflags, EndType newEnd, GameRooms gamerooms)
        {
            switch(GameData.CurrentRoom.Name)
            {
                case "open_mind_room":
                    playerflags.Open_Mind = true;
                    break;
                case "dark_woods":
                    if (playerflags.Slightly_JiuJitsu_Proficient)
                    {
                        playerflags.Shia_Defeated = true;
                        playerflags.Farores_Wind_Collected = true;
                    }
                    break;
                case "open_door":
                    newEnd.IsGameover = true;
                    newEnd.IsGoodEnding = true;
                    break;
                case "dojo":
                    gamerooms.dojo.IncrementCounter();
                    playerflags.Slightly_JiuJitsu_Proficient = true;
                    break;
                case "rock_room":
                    RockGame rockGame = new RockGame();
                    Console.WriteLine($"There are {rockGame.rockCount} rocks. Do you want to take rocks first?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    string userCommand = Console.ReadLine();
                    CheckStatement(userCommand, rockGame);
                    while(rockGame.winner == "none")
                    {
                        if(rockGame.rockCount % 3 == 2)
                        {
                            rockGame.PlayerTake("golem", 2);
                            Console.WriteLine("The golem takes 2 rocks.");
                        }
                        else if(rockGame.rockCount % 3 == 1)
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
                        Console.WriteLine("How many rocks will you take?");
                        Console.WriteLine("1. 1 rock");
                        Console.WriteLine("2. 2 rocks");
                        string newUserCommand = Console.ReadLine();
                        CheckStatement(newUserCommand, rockGame);
                    }
                    if (rockGame.winner == "golem")
                    {
                        Console.WriteLine("The golem says 'Better luck next time, sucker!'");
                        GameData.CurrentRoom = gamerooms.desert_village;
                    }
                    if (rockGame.winner == "player")
                    {
                        if (playerflags.Dins_Fire_Collected)
                        {
                            Console.WriteLine("The golem says 'You already have Din's fire, but you are stil brilliant!'");
                        }
                        else
                        {
                            Console.WriteLine("The golem says 'You beat me! Take this magic stone!'");
                        }
                        playerflags.Rock_Champion = true;
                        playerflags.Dins_Fire_Collected = true;
                        GameData.CurrentRoom = gamerooms.desert_village;
                    }
                    break;
                case "open_mind":
                    gamerooms.open_mind.IncrementCounter();
                    playerflags.Open_Mind = true;
                    break;
            }
        }
        public void CheckFlags(PlayerFlags playerFlags, EndType endType, GameRooms gamerooms)
        {
            if (playerFlags.Three_Stones_Collected)
            {
                gamerooms.temple_door.Choices.Add("3", gamerooms.open_door);
                gamerooms.temple_door.Options = new List<string>
                {
                    "Go back outside",
                    "Read the wall",
                    "Open the door"
                };
            }
            if (playerFlags.Farores_Wind_Collected)
            {
                gamerooms.spider_room.Description = RoomDescriptions.SpiderRoomWithFaroresWind;
            }
            if (playerFlags.Dins_Fire_Collected)
            {
                gamerooms.castle_entrance.Description = RoomDescriptions.CastleEntranceWithDinsFire;
                gamerooms.castle_entrance.Options.Clear();
                string[] newCastleEntranceOptions = { "Go back to the icy tundra entrance", "Go over the rickety bridge" };
                gamerooms.castle_entrance.Options.AddRange(newCastleEntranceOptions);
            }
            if (playerFlags.Shia_Defeated)
            {
                gamerooms.forest_entrance.Description = RoomDescriptions.ForestEntranceShiaDefeated;
                gamerooms.forest_village.Description = RoomDescriptions.ForestVillageShiaDefeated;
 
                gamerooms.forest_village.Choices.Clear();
                gamerooms.forest_village.Options.Clear();
                gamerooms.forest_village.Choices.Add("1", gamerooms.forest_entrance);
                gamerooms.forest_village.Choices.Add("2", gamerooms.dojo);
                string[] newForestVillageOptions = { "Go back to the forest entrance", "Go into the dojo" };
                gamerooms.forest_village.Options.AddRange(newForestVillageOptions);

                gamerooms.dojo.Choices.Clear();
                gamerooms.dojo.Options.Clear();
                gamerooms.dojo.Choices.Add("1", gamerooms.forest_village);
                gamerooms.dojo.Choices.Add("2", gamerooms.open_mind);
                string[] newDojoOptions = { "Go back to the village", "Meditate for an open mind" };
                gamerooms.dojo.Options.AddRange(newDojoOptions);
            }
            if (playerFlags.Slightly_JiuJitsu_Proficient && (gamerooms.dojo.Counter > 1))
            {
                gamerooms.dojo.Description = RoomDescriptions.DojoWithJiuJitsu;
            }
            if (GameData.CurrentRoom.Name == "dark_woods" && playerFlags.Slightly_JiuJitsu_Proficient)
            {
                ShiaScene shiaScene = new ShiaScene();
                gamerooms.dark_woods.Description = "Short victory for testing";
                //gamerooms.dark_woods.Description = shiaScene.Victory();
            }
            if (playerFlags.Open_Mind)
            {
                if(gamerooms.open_mind.Counter > 1)
                {
                    gamerooms.open_mind.Description = "You already know the way, now go punch something.";
                }
                gamerooms.village_wall.Description = RoomDescriptions.VillageWallWithOpenMind;
                
                gamerooms.village_wall.Choices.Clear();
                gamerooms.village_wall.Options.Clear();
                gamerooms.village_wall.Choices.Add("1", gamerooms.desert);
                gamerooms.village_wall.Choices.Add("2", gamerooms.desert_village);
                string[] newVillageWallOptions = { "Go back to the desert", "Go past the wall into the desert vilage" };
                gamerooms.village_wall.Options.AddRange(newVillageWallOptions);
            }
            if (playerFlags.Rock_Champion)
            {
                gamerooms.desert_village.Description = RoomDescriptions.DesertVillageAsRockChampion;
                
            }
        }
        public Boolean IsDead(PlayerFlags playerFlags)
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