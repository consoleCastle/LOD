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
        // Added comments for merge conflict testing- TESTING
        AsciiArt art = new AsciiArt();
        GameData data = new GameData();
        Room current_room { get; set; }
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

            //newEnd.IsGameover = true;
            //newEnd.CauseMessage = "This is a test Gameover message";
            data.CurrentRoom = SetUpRooms();
            while (!newEnd.IsGameover)
            {
                Console.WriteLine(data.CurrentRoom.Description);
                string userCommand = Console.ReadLine();
                CheckStatement(playerFlags, userCommand);
                CheckFlags(playerFlags, newEnd);
                if (IsDead())
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = data.CurrentRoom.Description;
                }
            }

            End(newEnd);

        }
        public Room SetUpRooms()
        {
            Room test_starting_room = new Room("test_starting_room", "This is the default description before you flip a switch in room 1. In room 2, you die. Instructions: Type the number of your choice and hit enter.\n1. Go to Room 1\n2. Go to Room 2");
            Room test_room_1 = new Room("test_room_1", "There is a switch in this room. Neato! Type 'a' to flip it. (a is for Action)\n1. Go back to the starting room\nA. Flip the switch!");
            Room test_room_2 = new Room("test_room_2", "Oh no! You died!");


            test_starting_room.Choices.Add("1", test_room_1);
            test_starting_room.Choices.Add("2", test_room_2);

            test_room_1.Choices.Add("1", test_starting_room);
            return test_starting_room;
        }
        public void CheckStatement(PlayerFlags playerFlags, string userCommand)
        {
            switch (userCommand)
            {
                case "a":
                    if (data.CurrentRoom.Name == "test_room_1")
                    {
                        playerFlags.Three_Stones_Collected = true;
                    }
                    break;
                case "Menu":
                    //TODO make the menu come up
                    break;
                default:
                    if (!data.CurrentRoom.Choices.ContainsKey(userCommand))
                    {
                        Console.WriteLine("That is not a valid choice");
                        break;
                    }
                    data.CurrentRoom = data.CurrentRoom.Choices[userCommand];
                    break;
            }
        }
        public void CheckFlags(PlayerFlags playerFlags, EndType endType)
        {
            if (playerFlags.Three_Stones_Collected)
            {
                data.CurrentRoom.Description = "You're a winner baby!";
                endType.IsGoodEnding = true;
                endType.IsGameover = true;
            }
        }
        public Boolean IsDead()
        {
            if (data.CurrentRoom.Name == "test_room_2")
            {
                return true;
            }
            return false;
        }
        public void RunLoadingAnimation(int seconds)
        {
            //LoadingAnimation loading = new LoadingAnimation();
            //loading.Delay = 500;
            //while (true) ---->Need logic to determine how long loading animation runs for
            //{
            //    loading.Run("Loading", sequenceCode: 1);
            //}
        }
        public void Reset()
        {
            //TODO
            //Need to reset all flags, options, and rooms to their defaults
            //Run reset rooms
            //roomSequence.reset() - For example
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
            //Run Reset()
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