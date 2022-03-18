using LOD.Classes;
using LOD.Utils;
using System;
using System.Collections.Generic;

namespace LOD.Tools
{
    class Checker
    {
        public static void CheckStatement(string userCommand, RockGame rockGame)
        {
            if (!rockGame.firstRockTaken)
            {
                switch (userCommand)
                {
                    case "1":
                        Console.WriteLine("How many rocks will you take first?");
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
            else switch (userCommand)
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

        public static void CheckRoom(PlayerFlags playerflags, EndType newEnd, GameRooms gamerooms)
        {
            switch (GameData.CurrentRoom.Name)
            {
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
                case "rock_game":
                    RockGame rockGame = new RockGame();
                    Console.WriteLine($"There are {rockGame.rockCount} rocks. Do you want to take rocks first?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    string userCommand = Console.ReadLine();
                    CheckStatement(userCommand, rockGame);
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
                        CheckStatement(newUserCommand, rockGame);
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
                    break;
                case "open_mind":
                    gamerooms.open_mind.IncrementCounter();
                    playerflags.Open_Mind = true;
                    break;
            }
        }

        public static void CheckFlags(PlayerFlags playerFlags, GameRooms gamerooms)
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
                if (gamerooms.open_mind.Counter > 1)
                {
                    gamerooms.open_mind.Description = "You already know the way, now go punch something.";
                }
                gamerooms.village_wall.Description = RoomDescriptions.VillageWallWithOpenMind;

                gamerooms.village_wall.Choices.Clear();
                gamerooms.village_wall.Options.Clear();
                gamerooms.village_wall.Choices.Add("1", gamerooms.desert);
                gamerooms.village_wall.Choices.Add("2", gamerooms.desert_village);
                string[] newVillageWallOptions = { "Go back to the desert", "Go past the wall into the desert village" };
                gamerooms.village_wall.Options.AddRange(newVillageWallOptions);
            }
            if (playerFlags.Rock_Champion)
            {
                gamerooms.desert_village.Description = RoomDescriptions.DesertVillageAsRockChampion;

            }
        }
    }
}
