using System;
using System.Collections.Generic;
using System.Text;
using LOD.Utils;

namespace LOD.Tools
{
    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        private bool ShowCommonMenuPrompt;

        public Menu(string prompt, string[] options, bool commonPrompt = false)
        {
            Prompt = prompt;
            Options = options;
            ShowCommonMenuPrompt = commonPrompt;
            SelectedIndex = 0;
        }

        private void ShowMenu()
        {
            Console.WriteLine(Prompt);
            for(int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if (i == SelectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix} << {currentOption} >>");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                ShowMenu();
                if (ShowCommonMenuPrompt)
                {
                    Console.WriteLine("Press 'm' to show Common Menu.");
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    if (SelectedIndex < Options.Length && SelectedIndex > 0)
                    {
                        SelectedIndex--;
                    }
                    else if (SelectedIndex == 0)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow) 
                {
                    if (SelectedIndex >= 0 && SelectedIndex < Options.Length - 1)
                    {
                        SelectedIndex++;
                    }
                    else if (SelectedIndex == Options.Length - 1)
                    {
                        SelectedIndex = 0;
                    }
                }
                else if (keyPressed == ConsoleKey.M)
                {
                    CommonMenu.ShowCommonMenu();
                }

            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
