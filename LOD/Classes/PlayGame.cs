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
        Typewriter typewriter = new Typewriter();
        public void Start()
        {
            Console.Clear();

            typewriter.GiveMeSpace();
            Console.WriteLine(data.TitleArt);
            //typewriter.Type(data.TitleArt);
            typewriter.GiveMeSpace();

            PlayerFlags playerFlags = new PlayerFlags();
            playerFlags.Reset();

            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            typewriter.Type(data.Exposition, moderateSpeed);
            typewriter.GiveMeSpace();

            // Start room sequence (starts at top of mountain [room 0], player works through rooms)
            //(This may not be where this process lives but) When player chooses option below is all the things that should happen
            //Check if player triggered game ending
            //IF Player triggered game ending
            // Run End(with passed endtype class)
            //Change player flags/status as necessary
            //Change player location if necessary

            EndType newEnd = new EndType();
            newEnd.IsGameover = true;
            newEnd.CauseMessage = "This is a test Gameover message";

            End(newEnd);

            UserCommonMenu userMenu = new UserCommonMenu();
            userMenu.MenuPrompt();

        }
        public void RunLoadingAnimation(int seconds)
        {   
            //LoadingAnimation loading = new LoadingAnimation();
            //loading.Delay = 500;
            //while (true)
            //{
            //    loading.Run("Loading", sequenceCode: 1);
            //}
        }
        public void Reset()
        {
            //Run reset rooms
              //roomSequence.reset() - In example
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
                Console.WriteLine(data.GameoverArt);
            }
            else
            {
                Console.WriteLine(data.VictoryArt);
            }

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
