using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;

namespace LOD.Utils
{
    class GameData
    {
        public static Room CurrentRoom { get; set; }
        public string RoomOneDescription = "This is the default description before you flip a switch in room 1. In room 2, you die.";
        public string[] RoomOneOptions = { "Go to Room 1", "Go To Room 2" };
        public string RoomTwoDescription = "There is a switch in this room. Neato!";
        public string[] RoomTwoOptions = { "Go back to the starting room", "Flip the switch!" };
        public string RoomThreeDescription = "Oh no! You died!";
    }
}
            