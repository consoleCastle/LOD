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
            Console.ForegroundColor = ConsoleColor.White;

            PlayerFlags playerFlags = new PlayerFlags();
            playerFlags.Reset();
            EndType newEnd = new EndType();

            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            typewriter.Type(art.Exposition, fastSpeed);
            typewriter.GiveMeSpace();
            GameRooms gamerooms = new GameRooms();
            GameData.CurrentRoom = gamerooms.mountain_top;
            while (!newEnd.IsGameover)
            {
                Console.WriteLine(GameData.CurrentRoom.Description);
                Console.WriteLine("");
                Console.WriteLine("Choose a location to go to next >");

                var i = 0;
                foreach (KeyValuePair<string, Room> choice in GameData.CurrentRoom.Choices)
                {
                    Console.WriteLine(choice.Key + ". " + GameData.CurrentRoom.Options[i]);
                    i++;
                }
                Console.WriteLine("");
                string userCommand = Console.ReadLine();
                CheckStatement(playerFlags, userCommand);
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
                gamerooms.forest_vilage.Description = "A peaceful village of forest elves lives in the trees! Their elder approaches you: ‘Thank you for saving our village traveler! You are always welcome here.";
                gamerooms.forest_vilage.Choices.Clear();
                Array.Clear(gamerooms.forest_vilage.Options, 0, gamerooms.forest_vilage.Options.Length);
                gamerooms.forest_vilage.Choices.Add("1", gamerooms.forest_entrance);
                gamerooms.forest_vilage.Options[0] = "Go back to the forest entrance";
                gamerooms.forest_vilage.Choices.Add("2", gamerooms.dojo);
                gamerooms.forest_vilage.Options[1] = "Go into the dojo";

                gamerooms.dojo.Choices.Add("2", gamerooms.open_mind_room);
            }
            if (playerFlags.Slightly_JiuJitsu_Proficient)
            {
                gamerooms.dojo.Description = "You enter the school. There are many students in white uniforms punching logs and throwing rocks. The school leader approaches you: ‘IF YOU CAN DODGE A ROCK, YOU CAN BODY SLAM A MONSTER!’ She hurls a rock at you but you barely get out of the way in time. ‘You have learned much, young grasshopper. You remind me of another student I once had… he had incredible power. I accidently called him by the wrong name once and he went wild with rage!";
                gamerooms.dark_woods.Description = "TODO: Shia victory sequence";
            }
            if (playerFlags.Open_Mind)
            {
                gamerooms.open_mind_room.Description = "“You already know the way, now go punch something.";
                gamerooms.vilage_wall.Description = "A great stone wall looms over you. Through the village entrance, you can see what seems to be moving rocks scattered about the village. It may be a mirage? As you approach, an immense, iron-wrought gate crashes shut over the entrance with a CLANG. Atop the gate a man in chainmail armor and a well-groomed mustache appears. The man begins to taunt you with an outrageous French accent but the enlightenment you received at the dojo tells you that he is merely projecting his own insecurities upon you. You remain composed and eventually the man gets bored and allows you to pass through.";
                gamerooms.vilage_wall.Choices.Clear();
                Array.Clear(gamerooms.vilage_wall.Options, 0, gamerooms.vilage_wall.Options.Length);
                gamerooms.vilage_wall.Choices.Add("1", gamerooms.desert);
                gamerooms.vilage_wall.Options[0] = "Go back to the desert";
                gamerooms.vilage_wall.Choices.Add("2", gamerooms.desert_vilage);
                gamerooms.vilage_wall.Options[1] = "Go past the wall into the desert vilage";
            }
        }
        public Boolean IsDead(PlayerFlags playerFlags)
        {
            if (GameData.CurrentRoom.Name == "dark_woods" && !playerFlags.Slightly_JiuJitsu_Proficient)
            {
                GameData.CurrentRoom.Description = "you dead";
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