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
        //GameData data = new GameData();
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
            GameData.CurrentRoom = SetUpRooms();
            while (!newEnd.IsGameover)
            {
                GameData.CurrentRoom = GameData.CurrentRoom.ShowMenu(GameData.CurrentRoom.Description, GameData.CurrentRoom.Options);
                CheckFlags(playerFlags, newEnd);
                if (IsDead())
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = GameData.CurrentRoom.Description;
                }
            }

            End(newEnd);
        }

        public static Room SetUpRooms()
        {
            GameData roomData = new GameData();

            Room test_starting_room = new Room("test_starting_room", roomData.RoomOneDescription, roomData.RoomOneOptions);
            Room test_room_1 = new Room("test_room_1", roomData.RoomTwoDescription, roomData.RoomTwoOptions);
            Room test_room_2 = new Room("test_room_2", roomData.RoomThreeDescription);


            test_starting_room.Choices.Add("1", test_room_1);
            test_starting_room.Choices.Add("2", test_room_2);

            test_room_1.Choices.Add("1", test_starting_room);

            return test_starting_room;
        }

        public void CheckFlags(PlayerFlags playerFlags, EndType endType)
        {
            if (playerFlags.Three_Stones_Collected)
            {
                GameData.CurrentRoom.Description = "You're a winner baby!";
                endType.IsGoodEnding = true;
                endType.IsGameover = true;
            }
        }
        public Boolean IsDead()
        {
            if (GameData.CurrentRoom.Name == "test_room_2")
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