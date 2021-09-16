using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;
using LOD.Tools;

namespace LOD.Classes
{
    class PlayGame
    {
        GameData data = new GameData();
        Room current_room {get; set;}
        Typewriter typewriter = new Typewriter();
        public void Start()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            typewriter.GiveMeSpace();
            Console.WriteLine(data.TitleArt);
            //Thread.Sleep(5000);
            LoadingAnimation loading = new LoadingAnimation();
            loading.Delay = 500;
            PlayerFlags playerFlags = new PlayerFlags();
            playerFlags.Reset();
            EndType newEnd = new EndType();
            while(!newEnd.IsGameover)
            {
                Console.WriteLine(data.CurrentRoom.Description);
                string userCommand = Console.ReadLine();
                data.CheckStatement(userCommand);
                if (data.IsDead())
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = data.CurrentRoom.Description;
                }
            }
/*            while (true)
            {
                loading.Run("Loading", sequenceCode: 1);
            }*/
            typewriter.GiveMeSpace();
            Console.ForegroundColor = ConsoleColor.White;


            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            //ConsoleHelper.SetCurrentFont("Lucida Console", 12);

            //index into string at character limit do whitespace vs char check
            typewriter.Type(data.Exposition, moderateSpeed);
            typewriter.GiveMeSpace();


            // Start room sequence (starts at top of mountain [room 0], player works through rooms)
            //(This may not be where this process lives but) When player chooses option below is all the things that should happen
            //Check if player triggered game ending
            //IF Player triggered game ending
            // Run End(with passed endtype class)
            //Change player flags/status as necessary
            //Change location if necessary

            
            //newEnd.IsGameover = true;
            //newEnd.CauseMessage = "This is a test Gameover message";

            End(newEnd);

        }
        public void RunLoadingAnimation(int seconds)
        {   
            //LoadingAnimation loading = new LoadingAnimation();
            //loading.Delay = 500;
            //while (true) ---->Need logic to determine how long loading animation runs for
            //{
            //    loading.Run("Loading", sequenceCode: 1);
            //}
        }
        public void Reset()
        {
            //Need to reset all flags, options, and rooms to their defaults
            //Run reset rooms
              //roomSequence.reset() - For example
        }
        public void ThanksForPlaying()
        {
            Console.WriteLine("Thanks for playing!!!");
        }
        public void End(EndType endType)
        {
            Console.WriteLine(endType.CauseMessage);
            typewriter.GiveMeSpace();

            if (endType.IsGameover)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data.GameoverArt);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data.VictoryArt);
            }

            Console.ForegroundColor = ConsoleColor.White;
            //Run Reset()
            Thread.Sleep(5000);
            typewriter.GiveMeSpace();
            Console.WriteLine("Would you like to play again? Respond with YES or NO.");
            typewriter.GiveMeSpace();
            string UserResponse = Console.ReadLine().ToLower();
            if ((UserResponse == "yes") || (UserResponse == "y"))
            {
                Start();
            }
            else
            {
                ThanksForPlaying();
            }
        }
        
    }
}
