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
            // Add timer / loading screen
            // Print setting and character exposition
            // Start room sequence (starts at top of mountain, player works through rooms)
            // if character triggers game ending
              // Run End(with passed endtype class)

        }
        public void ThanksForPlaying()
        {
            //Print thank you message and credits
            //Close console app
        }
        public void Reset()
        {
            //Run reset player flags
            //Run reset player location (?)
        }
        public void End(EndType endType)
        {
            //If endtype is equal to gameover
            //Console.WriteLine(EndType.Message);
            //Thread.Sleep(1000);
            //Console.WriteLine(data.Gameover);

            //If endtype is equal to success
            //Console.WriteLine(EndType.Message);
            //Thread.Sleep(1000);
            //Console.WriteLine(data.Success);

            //Run Reset()
            //Thread.Sleep(5000);
            //Ask player if they would like to play again
            //If "yes" run Start()
            //If "no" run ThanksForPlaying()
        }
        public void RunLoadingAnimation(int seconds)
        {
            /*
            Thread.Sleep(5000);
            
            LoadingAnimation loading = new LoadingAnimation();
            loading.Delay = 500;
            while (true)
            {
                loading.Run("Loading", sequenceCode: 1);
            }
            */
        }
    }
}
