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
        public int Counter { get; set; }
        public Room(string name, string description, List<string> options = null, int counter = 0)
        {
            Name = name;
            Description = description;
            Options = options;
            Choices = new Dictionary<string, Room>();
            Counter = counter;
        }

        public Room ShowMenu(string prompt, List<string> options)
        {
            bool showCommonPrompt = Name == "mountain_top" ? true : false;
            Menu roomMenu = new Menu(prompt, options, showCommonPrompt);
            int selectedIndex = roomMenu.Run();
            string selection = (selectedIndex + 1).ToString();

            return Choices[selection];
        }
        public void IncrementCounter()
        {
            Counter++;
        }
    }
}
