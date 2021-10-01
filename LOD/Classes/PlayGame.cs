using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;
using LOD.Tools;
using LOD.Utils;

namespace LOD.Classes
{
    class PlayGame
    {
        AsciiArt art = new AsciiArt();
        GameData data = new GameData();
        Room current_room {get; set;}
        Typewriter typewriter = new Typewriter();
        public void Start()
        {
            Console.Clear();

            /*            Console.ForegroundColor = ConsoleColor.Yellow;
                        typewriter.GiveMeSpace();
                        Console.WriteLine(art.TitleArt);
                        typewriter.GiveMeSpace();
                        Console.ForegroundColor = ConsoleColor.White;



            PlayerFlags playerFlags = new PlayerFlags();
            playerFlags.Reset();
            EndType newEnd = new EndType();

                        int slowSpeed = (int)Typewriter.Speed.slow;
                        int moderateSpeed = (int)Typewriter.Speed.moderate;
                        int fastSpeed = (int)Typewriter.Speed.fast;

                        typewriter.Type(art.Exposition, fastSpeed);
                        typewriter.GiveMeSpace();*/

            /*Adding bad comments to trigger a merge conflict*/
            /*Adding bad comments to trigger a merge conflict*/
            /*Adding bad comments to trigger a merge conflict*/
            /*Adding bad comments to trigger a merge conflict*/
            /*Adding bad comments to trigger a merge conflict*/

            //newEnd.IsGameover = true;
            //newEnd.CauseMessage = "This is a test Gameover message";
            data.CurrentRoom = data.SetUpRooms();
            /*Adding bad comments to trigger a merge conflict*/
            while (!newEnd.IsGameover)
            {
                Console.WriteLine(data.CurrentRoom.Description);
                string userCommand = Console.ReadLine();
                data.CheckStatement(playerFlags,userCommand);
                data.CheckFlags(playerFlags, newEnd);
                if (data.IsDead())
                {
                    newEnd.IsGameover = true;
                    newEnd.CauseMessage = data.CurrentRoom.Description;
                }
            }

            End(newEnd);

        }

        public void Reset()
        {
            //TODO
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

            if (!endType.IsGoodEnding)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(art.GameoverArt);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(art.VictoryArt);
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
