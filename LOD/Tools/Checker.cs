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
            Typewriter typewriter = new Typewriter();
            KingDallenScene kingDallenScene = new KingDallenScene();

            switch (GameData.CurrentRoom.Name)
            {
                case "read_the_wall":
                    Counter.read_the_wall++;
                    break;
                case "open_door":
                    newEnd.IsGameover = true;
                    newEnd.IsGoodEnding = true;
                    break;
                case "forest_village":
                    Counter.forest_village++;
                    break;
                case "dojo":
                    Counter.dojo++;
                    playerflags.Slightly_JiuJitsu_Proficient = true;
                    break;
                case "open_mind":
                    Counter.open_mind++;
                    playerflags.Open_Mind = true;
                    break;
                case "dark_woods":
                    Counter.dark_woods++;
                    if (playerflags.Slightly_JiuJitsu_Proficient)
                    {
                        playerflags.Shia_Defeated = true;
                        playerflags.Farores_Wind_Collected = true;
                    }
                    break;
                case "taunt":
                    gamerooms.taunt.Description = TauntGenerator.Taunt();
                    break;
                case "village_wall":
                    Counter.desert_wall++ ;
                    if (!playerflags.Open_Mind)
                    {
                        gamerooms.village_wall.Description = $"A great stone wall looms over you. Through the village entrance, you can see what seems to be moving rocks scattered about the village. It may be a mirage? As you approach, an immense, iron-wrought gate crashes shut over the entrance with a CLANG. Atop the gate a man in chain mail armor and a well-groomed mustache appears. In an outrageous French accent, the man shouts down at you: ‘{TauntGenerator.Taunt()}’. The taunt cuts deep and you have no retort. The frustration is too much to bear and you feel that you must turn back to compose yourself.";
                    }
                    break;
                case "desert_village":
                    Counter.desert_village++;
                    break;
                case "rock_game":
                    PlayRockGame playrockgame = new PlayRockGame();
                    playrockgame.Play(gamerooms, playerflags);
                    break;
                case "icy_tundra":
                    Counter.icy_tundra++;
                    break;
                case "ravine":
                    Counter.ravine++;
                    break;
                case "shelobs_lair":
                    Counter.shelobs_lair++;
                    break;
                case "castle_entrance":
                    Counter.castle_entrance++;
                    break;
                case "skeleton_room":
                    Counter.skeleton_room++;
                    break;
                case "throne_room":
                    if (!playerflags.Nayrus_Love_Collected)
                    {
                        kingDallenScene.Play(gamerooms, playerflags);
                    }
                    Counter.throne_room++;
                    break;
            }
        }
        public static void CheckFlags(PlayerFlags playerFlags, GameRooms gamerooms)
        {
            if (playerFlags.Farores_Wind_Collected && playerFlags.Dins_Fire_Collected && playerFlags.Nayrus_Love_Collected)
            {
                playerFlags.Three_Stones_Collected = true;
            }
            if (playerFlags.Three_Stones_Collected)
            {
                gamerooms.temple_door.Choices.Clear();
                gamerooms.temple_door.Choices.Add("1", gamerooms.mountain_top);
                gamerooms.temple_door.Choices.Add("2", gamerooms.read_the_wall);
                gamerooms.temple_door.Choices.Add("3", gamerooms.open_door);
                gamerooms.temple_door.Options.Clear();
                gamerooms.temple_door.Options = new List<string>
                {
                    "Go back outside",
                    "Read the wall",
                    "Open the door"
                };
            }
            if (playerFlags.Farores_Wind_Collected)
            {
                if(Counter.shelobs_lair > 1)
                {
                    gamerooms.shelobs_lair.Description = RoomDescriptions.ShelobsLairAfterSuccess;
                } else
                {
                    gamerooms.shelobs_lair.Description = RoomDescriptions.ShelobsLairWithFaroresWind;
                }
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
            if (playerFlags.Slightly_JiuJitsu_Proficient && (Counter.dojo > 1))
            {
                gamerooms.dojo.Description = RoomDescriptions.DojoWithJiuJitsu;
            }
            if (GameData.CurrentRoom.Name == "dark_woods" && playerFlags.Slightly_JiuJitsu_Proficient)
            {
                ShiaScene shiaScene = new ShiaScene();
                gamerooms.dark_woods.Description = shiaScene.Victory();
            }
            if (playerFlags.Open_Mind)
            {
                if (Counter.open_mind > 1)
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
            if (GameData.CurrentRoom.Name == "joke_success")
            {
                gamerooms.skeleton_room.Description = RoomDescriptions.SkeletonRoomSuccess;

                gamerooms.skeleton_room.Choices.Clear();
                gamerooms.skeleton_room.Options.Clear();
                gamerooms.skeleton_room.Choices.Add("1", gamerooms.icy_tundra);
                gamerooms.skeleton_room.Choices.Add("2", gamerooms.throne_room);
                string[] newSkeletonRoomOptions = { "Leave the Castle", "Enter the Throne Room" };
                gamerooms.skeleton_room.Options.AddRange(newSkeletonRoomOptions);
            }
            if (playerFlags.Nayrus_Love_Collected)
            {
                gamerooms.skeleton_room.Description = RoomDescriptions.SkeletonRoomAfterNaryusLove;
            }
        }
    }
}

