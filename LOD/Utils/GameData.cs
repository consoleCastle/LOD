using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;

namespace LOD.Classes
{
    class GameData
    {
        public Room CurrentRoom { get; set; } 
        public GameData()
        {
            CurrentRoom = SetUpRooms();
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
        public void CheckStatement (PlayerFlags playerFlags, string userCommand)
        {
            switch(userCommand)
            {
                case "a":
                    if(CurrentRoom.Name == "test_room_1")
                    {
                        playerFlags.Three_Stones_Collected = true;
                    }
                    break;
                case "Menu":
                    //TODO make the menu come up
                    break;
                default:
                    if(!CurrentRoom.Choices.ContainsKey(userCommand))
                    {
                        Console.WriteLine("That is not a valid choice");
                        break;
                    }
                    CurrentRoom = CurrentRoom.Choices[userCommand];
                    break;
            }
        }
        public void CheckFlags(PlayerFlags playerFlags, EndType endType)
        {
            if (playerFlags.Three_Stones_Collected)
            {
                CurrentRoom.Description = "You're a winner baby!";
                endType.IsGoodEnding = true;
                endType.IsGameover = true;
            }
        }
        public Boolean IsDead()
        {
            if (CurrentRoom.Name == "test_room_2")
            {
                return true;
            }
            return false;
        }

    }
}
