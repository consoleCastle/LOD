<<<<<<< HEAD
using System.Collections.Generic;
namespace LOD.Classes
{
    public class Room
    {
            public string Description { get; set; }
            public Dictionary<string, Room> Choices {get; set;}
        public Room(string description)
        {
            Description = description;
            Choices = new Dictionary<string, Room>();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, Room> Directions { get; set; }
        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Directions = new Dictionary<string, Room>();
        }
    }
}
>>>>>>> master
