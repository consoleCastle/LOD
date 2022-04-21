using System;
using System.Collections.Generic;
using LOD.Interfaces;

namespace LOD.Tools
{
    class Menu : IMenu
    {
        private int SelectedIndex;
        private List<string> Options;
        private string Prompt;
        private bool ShowCommonMenuPrompt;
        private int renderCounter;

        public Menu(string prompt, List<string> options, bool commonPrompt = false)
        {
            Prompt = prompt;
            Options = options;
            ShowCommonMenuPrompt = commonPrompt;
            SelectedIndex = 0;
            renderCounter = 1;
        }

        private void ShowMenu()
        {
            Typewriter typewriter = new Typewriter();
            int fastSpeed = (int)Typewriter.Speed.fast;

            if (renderCounter == 1)
            {
                typewriter.Type(Prompt, fastSpeed);
            }
            else
            {
                typewriter.Skip(Prompt);
            }
            for(int i = 0; i < Options.Count; i++)
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
            renderCounter++;
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
                    if (SelectedIndex < Options.Count && SelectedIndex > 0)
                    {
                        SelectedIndex--;
                    }
                    else if (SelectedIndex == 0)
                    {
                        SelectedIndex = Options.Count - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow) 
                {
                    if (SelectedIndex >= 0 && SelectedIndex < Options.Count - 1)
                    {
                        SelectedIndex++;
                    }
                    else if (SelectedIndex == Options.Count - 1)
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
