using System;
using System.Collections.Generic;
using System.Text;
using LOD.Classes;
using LOD.Tools;
using LOD.Utils;

namespace LOD.Classes
{
    class KingDallenScene
    {
        Typewriter typewriter = new Typewriter();
        GameRooms gamerooms = new GameRooms();
        PlayerFlags playerflags = new PlayerFlags();
        public void Play()
        {
            Console.Clear();
            typewriter.Type(gamerooms.throne_room.Description, 60);
            typewriter.GiveMeSpace();
            Console.ForegroundColor = ConsoleColor.Red;
            typewriter.Type("Type in your guess and press enter!", 60, true);
            Console.ForegroundColor = ConsoleColor.White;
            string dallenNameGuess = Console.ReadLine();
            Console.WriteLine($"You guessed '{dallenNameGuess}'");
            if (dallenNameGuess.ToLower() == "john")
            {
                playerflags.Nayrus_Love_Collected = true;
                Console.WriteLine("You guessed my name! 'JOHN'! Not only will I let you live, but I will give you this magic stone! Now go away.");
                Console.WriteLine("");
                Console.WriteLine("You got Naryu's Love! Press ANY KEY to continue.");
                Console.ReadLine();
                GameData.CurrentRoom = gamerooms.three_stones_collected;
                gamerooms.skeleton_room.Description = RoomDescriptions.SkeletonRoomAfterNaryusLove;
                gamerooms.skeleton_room.Choices.Clear();
                gamerooms.skeleton_room.Choices.Add("1", gamerooms.icy_tundra);
                gamerooms.skeleton_room.Options.Clear();
                gamerooms.skeleton_room.Options = new List<string>
                {
                    "Leave the Castle"
                };
            }
        }
    }
}
