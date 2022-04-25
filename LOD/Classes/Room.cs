using System.Collections.Generic;
using LOD.Interfaces;
using LOD.Tools;


namespace LOD.Classes
{
    class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Options { get; set; }
        public Dictionary<string, Room> Choices { get; set; }
        public int[] Coordinate { get; set; }
        public Room(string name, string description, int[] coordinate, List<string> options = null)
        {
            Name = name;
            Description = description;
            Coordinate = coordinate;
            Options = options;
            Choices = new Dictionary<string, Room>();
        }

        public Room ShowMenu(string prompt, List<string> options)
        {
            bool showCommonPrompt = Name == "mountain_top" ? true : false;
            Menu roomMenu = new Menu(prompt, options, showCommonPrompt);
            int selectedIndex = roomMenu.Run();
            string selection = (selectedIndex + 1).ToString();

            return Choices[selection];
        }
    }
}
