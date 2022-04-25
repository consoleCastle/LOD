using System;
using System.Collections.Generic;
using System.Text;
using LOD.Utils;

namespace LOD.Tools
{
    class CommonMenu
    {
        private static string prompt = "Welcome to the Menu";
        private static List<string> options = new List<string> { "Show Map", "Close Menu" };
        public static void ShowCommonMenu()
        {
            Menu commonMenu = new Menu(prompt, options);
            int selectedIndex = commonMenu.Run();

            switch(selectedIndex)
            {
                case 0:
                    Console.Clear();
                    ShowMap();
                    break;
                case 1:
                    Console.Clear();
                    break;
            }
        }

        private static void ShowMap()
        {
            MapBuilder mapBuilder = new MapBuilder();
            mapBuilder.PrintMap();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey(true);
            ShowCommonMenu();
        }
    }

}
