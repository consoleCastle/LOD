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
            slow = 100,
            moderate = 40,
            fast = 10
        }
        public void Type(string message, int speed)
        {
            TypeWithLineBreaks(0, message, speed);
        }

        public void TypeWithLineBreaks(int indexStart, string message, int speed)
        {
            //Stopping Condition
            if (message.Length - indexStart <= Console.WindowWidth)
            {
                for (var i = indexStart; i < message.Length; i++)
                {
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
                    char currentChar = message[i];
                    Console.Write(currentChar);
                    if ((currentChar == '.') || (currentChar == '?') || (currentChar == '!') || (currentChar == ','))
                    {
                        Thread.Sleep(150);
                    }
                    Thread.Sleep(speed);
                }
                Console.WriteLine("");
                // Recursion, yay
                TypeWithLineBreaks(endIndex + 1, message, speed);
            }
        }

        public void GiveMeSpace()
        {
            Thread.Sleep(500);
            Console.WriteLine(new string('-', 100));
            Thread.Sleep(500);
        }
    }
}
