using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class UserCommonMenu
    {
        public void MenuPrompt()
        {
            Console.WriteLine("Type h or help for menu");
            string userInput = Console.ReadLine().ToLower();
            ShowMenu(userInput);
        }

        private void ShowMenu(string userInput)
        {
            if ((userInput == "h") || (userInput == "help"))
            {
                Console.WriteLine("Congratulations, here's a menu!");
            }
            else
            {
                Console.WriteLine("Please enter a valid command");
                Console.WriteLine("Valid commands are h or help");
            }
        }
    }
}
