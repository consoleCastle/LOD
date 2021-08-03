using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace LOD.Tools
{
    class Typewriter
    {
        public void Type(string message)
        {
            for (var i = 0; i < message.Length; i++)
            {
                char currentChar = message[i];
                Console.Write(currentChar);
                if ((currentChar == '.') || (currentChar == '?') || (currentChar == '!') || (currentChar == ','))
                {
                    Thread.Sleep(150);
                }
                Thread.Sleep(50);
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
