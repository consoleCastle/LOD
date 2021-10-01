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

        }
    }
}
            