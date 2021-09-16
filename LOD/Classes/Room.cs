using System.Collections.Generic;
namespace LOD.Classes
{
    public class Room
    {
            public string Name { get; set; }
            public string Description { get; set; }
            public Dictionary<string, Room> Choices {get; set;}
        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Choices = new Dictionary<string, Room>();
        }
    }
}
