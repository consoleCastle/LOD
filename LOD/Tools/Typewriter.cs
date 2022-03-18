using System;
using System.Threading;
using LOD.Interfaces;

namespace LOD.Tools
{
    class Typewriter : ITypewriter
    {
        public enum Speed
        {
            slow = 95,
            moderate = 60,
            fast = 33
        }
        public void Type(string message, int speed, bool hideSkip = false, bool isBrokenMsg = false)
        {
            if (!hideSkip)
            {
                LetUserKnowTheyCanSkip();
            }
            TypeWithLineBreaks(0, message, speed, isBrokenMsg);
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
            skipWithLineBreaks(0, message);
        }

        public void LetUserKnowTheyCanSkip()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Press s to skip...");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void TypeWithLineBreaks(int indexStart, string message, int speed, bool isBrokenMsg = false)
        {
            if (message.Length - indexStart <= Console.WindowWidth)
            {
                for (var i = indexStart; i < message.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.S)
                    {
                        if (isBrokenMsg)
                        {
                            throw new Exception("User wants to skip typing scene"); 
                        } 
                        else
                        {
                            Skip(message);
                            return;
                        }
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
        public void skipWithLineBreaks(int indexStart, string message)
        {
            if(message.Length - indexStart <= Console.WindowWidth)
            {
                string remainingMessage = message.Substring(indexStart);
                Console.WriteLine(remainingMessage);
            }
            else
            {
                int endIndex = indexStart + Console.WindowWidth;
                while (message[endIndex] != ' ')
                {
                    endIndex--;
                }
                int substringLength = endIndex - indexStart;
                string currentMessageSubstring = message.Substring(indexStart, substringLength);
                Console.WriteLine(currentMessageSubstring);
                skipWithLineBreaks(endIndex + 1, message);
            }
        }

    }
}
