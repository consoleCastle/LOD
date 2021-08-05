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
            moderate = 50,
            fast = 25
        }
        public void Type(string message, int speed)
        {
            for (var i = 0; i < message.Length; i++)
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

        public void GiveMeSpace()
        {
            Thread.Sleep(700);
            Console.WriteLine(new string('-', 100));
            Thread.Sleep(700);
        }
    }
}
