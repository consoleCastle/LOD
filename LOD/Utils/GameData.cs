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
        private string RoomOneDescription = "This is the default description before you flip a switch in room 1. In room 2, you die. Instructions: Type the number of your choice and hit enter.";
        private string[] RoomOneOptions = { "Go to Room 1", "Go To Room 2" };
        private string RoomTwoDescription = "There is a switch in this room. Neato! Type 'a' to flip it. (a is for Action)\n1. Go back to the starting room\nA. Flip the switch!";
        private string[] RoomTwoOptions = { "Go back to the starting room", "Flip the switch!" };
        private string RoomThreeDescription = "Oh no! You died!";
        public GameData()
        {
            CurrentRoom = SetUpRooms();
        }

        public Room SetUpRooms() 
        {
            Room test_starting_room = new Room("test_starting_room", RoomOneDescription, RoomOneOptions);
            Room test_room_1 = new Room("test_room_1", RoomTwoDescription, RoomTwoOptions);
            Room test_room_2 = new Room("test_room_2", RoomThreeDescription);


            test_starting_room.Choices.Add("1", test_room_1);
            test_starting_room.Choices.Add("2", test_room_2);
            test_starting_room.ShowMenu(test_starting_room.Options);

            test_room_1.Choices.Add("1", test_starting_room);
            return test_starting_room;
        }
        public void CheckStatement(PlayerFlags playerFlags, string userCommand)
        {
            switch (userCommand)
            {
                case "a":
                    if (CurrentRoom.Name == "test_room_1")
                    {
                        playerFlags.Three_Stones_Collected = true;
                    }
                    break;
                case "Menu":
                    //TODO make the menu come up
                    break;
                default:
                    if (!CurrentRoom.Choices.ContainsKey(userCommand))
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
            