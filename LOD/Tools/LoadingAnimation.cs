using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace LOD.Tools
{
    class LoadingAnimation
    {
        static string[,] sequence = null;
        public int Delay { get; set; } = 200;
        int totalSequences = 0;
        int counter;

        public LoadingAnimation()
        {
            counter = 0;
            sequence = new string[,]
            {
                { ".                      ","..","...", "...@/", "...@/.","...@/..", "...@/...", @"...@/...\<>/", @"...@/...\<>/.",@"...@/...\<>/..",@"...@/...\<>/...",@"...@/...\<>/...o°o",@"...@/...\<>/...o°o",@"...@/...\<>/...o°o.",@"...@/...\<>/...o°o..",@"...@/...\<>/...o°o..." },
            };
            totalSequences = sequence.GetLength(0);
        }
        public void Run(string displayMsg = "", int sequenceCode = 0)
        {
            counter++;

            Thread.Sleep(Delay);

            sequenceCode = sequenceCode > totalSequences - 1 ? 0 : sequenceCode;

            int counterValue = counter % 16;

            string fullMessage = displayMsg + sequence[sequenceCode, counterValue];
            int msglength = fullMessage.Length;

            Console.Write(fullMessage);

            Console.SetCursorPosition(Console.CursorLeft - msglength, Console.CursorTop);
        }
    }
}

/*
 * How to Call this
 *         public void RunLoadingAnimation(int seconds)
        {   
            //LoadingAnimation loading = new LoadingAnimation();
            //loading.Delay = 500;
            //while (true) ---->Need logic to determine how long loading animation runs for
            //{
            //    loading.Run("Loading", sequenceCode: 1);
            //}
        }
 */