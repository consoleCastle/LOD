using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;

namespace LOD.Classes
{
    class PlayGame
    {
        GameData data = new GameData();
        public void Start()
        {
            Console.WriteLine(data.lineSpacer);
            Console.WriteLine(data.TitleArt);
            Console.WriteLine(data.lineSpacer);
            // Print beginning setting and character exposition
            // Start room sequence (starts at top of mountain, player works through rooms)
            //(This may not be where this process lives but) When player chooses option below is all the things that should happen
              //Check if player triggered game ending
                //IF Player triggered game ending
                  // Run End(with passed endtype class)
              //Change player flags/status as necessary
              //Change player location if necessary

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
            //Run reset player flags
            //Run reset player location (?)
        }
        public void ThanksForPlaying()
        {
            //Print thank you message and roll credits
            //Close console app
        }
        public void End(EndType endType)
        {
            //Console.WriteLine(endType.Message);
            //Thread.Sleep(1000);
            
            //If endtype.IsGameover is true
              //Console.WriteLine(data.Gameover);
            //Else If endtype.IsGameover is false
              //Console.WriteLine(data.Victory);

            //Run Reset()
            //Thread.Sleep(5000);
            //Ask player if they would like to play again
              //If "yes" run Start()
              //If "no" run ThanksForPlaying()
        }
    }
}
