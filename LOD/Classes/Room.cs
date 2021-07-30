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