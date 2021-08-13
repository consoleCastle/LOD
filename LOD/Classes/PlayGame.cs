using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;

namespace LOD.Classes
{
    class PlayGame
    {
        GameData data = new GameData();
        Room current_room {get; set;}
        public void Start()
        {
            Console.WriteLine(data.TitleArt);
            //Thread.Sleep(5000);
            LoadingAnimation loading = new LoadingAnimation();
            loading.Delay = 500;
            while (true)
            {
                loading.Run("Loading", sequenceCode: 1);
            }
        }
        public void GameOver()
        {
            Console.WriteLine("You have died.");
            Thread.Sleep(1000);
            Console.WriteLine(data.Gameover);
        }
        public Room SetUpRooms()
        {
          Room test_starting_room = new Room("This is the default description before you flip a switch in room 1. In room 2, ypu die. Instructions: Type the number of your choice and hit enter.\n1. Go to Room 1\n2.Go to Room 2");
          Room test_room_1 = new Room("There is a switch in this room. Neato! Type 'A' to flip it. (A is for Action)\n1. Go back to the starting room\nA. Flip the switch!");
          Room test_room_2 = new Room("Oh no! You died!");
        

          test_starting_room.Choices.Add("1", test_room_1);
          test_starting_room.Choices.Add("2", test_room_2);

          test_room_1.Choices.Add("1", test_starting_room);
          return test_starting_room;  
        }
    }
}
