using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace LOD.Tools
{
    class Typewriter
    {
        public enum Speed
        {
            slow = 95,
            moderate = 60,
            fast = 33
        }
        public void Type(string message, int speed)
        {
            TypeWithLineBreaks(0, message, speed);
        }

        public void GiveMeSpace()
        {
            Thread.Sleep(500);
            Console.WriteLine(new string('-', 100));
            Thread.Sleep(500);
        }

        public void Skip(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }

        public void LetUserKnowTheyCanSkip()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Press s to skip...");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void TypeWithLineBreaks(int indexStart, string message, int speed)
        {
            if (message.Length - indexStart <= Console.WindowWidth)
            {
                for (var i = indexStart; i < message.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.S)
                    {
                        Console.Clear();
                        Console.WriteLine(message);
                        return;
                    }
                    char currentChar = message[i];
                    Console.Write(currentChar);
                    if ((currentChar == '.') || (currentChar == '?') || (currentChar == '!') || (currentChar == ','))
                    {
                        Thread.Sleep(150);
                    }
                    Thread.Sleep(speed);
                }
                Console.WriteLine("");
            }
            else
            {
                int endIndex = indexStart + Console.WindowWidth;
                while (message[endIndex] != ' ')
                {
                    endIndex--;
                }
                LetUserKnowTheyCanSkip();
                for (var i = indexStart; i <= endIndex; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.S)
                    {
                        Skip(message);
                        return;
                    }
                    char currentChar = message[i];
                    Console.Write(currentChar);
                    if ((currentChar == '.') || (currentChar == '?') || (currentChar == '!') || (currentChar == ','))
                    {
                        Thread.Sleep(150);
                    }
                    Thread.Sleep(speed);
                }
                Console.WriteLine("");
                TypeWithLineBreaks(endIndex + 1, message, speed);
            }
        }

    }
}
