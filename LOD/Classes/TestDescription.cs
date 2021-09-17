using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using LOD.Tools;

namespace LOD.Classes
{
    class TestDescription
    {
        GameData gameData = new GameData();

        public void PrintShiaArt(string shiaArt, ConsoleColor color)
        {
            Thread.Sleep(500);
            Console.ForegroundColor = color;
            Console.WriteLine(shiaArt);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(900);
        }

        public void PlayDarkWoodsScene_Failure()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            typewriter.Type("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed);
            PrintShiaArt(gameData.Shia1, ConsoleColor.Red);
            typewriter.Type("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed);
            PrintShiaArt(gameData.Shia2, ConsoleColor.Red);
            typewriter.Type("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face and", fastSpeed);
            typewriter.Type("AHH!", fastSpeed);
            Thread.Sleep(300);
            typewriter.Type("Your Leg!", fastSpeed);
            Thread.Sleep(300);
            typewriter.Type("It's caught in a bear trap!", fastSpeed);
            typewriter.Type("You are eaten by ACTUAL CANNIBAL Shia LeBeuof.", moderateSpeed);
        }
        public void PlayDarkWoodsScene_Victory()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            typewriter.Type("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed);
            PrintShiaArt(gameData.Shia1, ConsoleColor.Red);
            typewriter.Type("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed);
            PrintShiaArt(gameData.Shia2, ConsoleColor.Red);
            typewriter.Type("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face,", fastSpeed);
            Thread.Sleep(300);
            typewriter.Type("MY GOD there's blood EVERYWHERE!", fastSpeed);
            Thread.Sleep(500);
            typewriter.Type("Acting on raw instinct, you wrestle a knife from Hollywood’s", moderateSpeed);
            PrintShiaArt(gameData.Shia3, ConsoleColor.Red);
            typewriter.Type("Slicing downwards you are able to stab him in his kidney.", moderateSpeed);
            Thread.Sleep(300);
            typewriter.Type("After a horrific gasp, he falls to the ground, dead.", slowSpeed);
            Thread.Sleep(1100);
            typewriter.GiveMeSpace();
            Console.WriteLine("FAKE OPTION SCREEN HERE");
            typewriter.GiveMeSpace();
            Thread.Sleep(8000);
            typewriter.Type("WAIT!", moderateSpeed);
            Thread.Sleep(300);
            typewriter.Type("He isn't dead!!", fastSpeed);
            PrintShiaArt(gameData.ShiaSurprise, ConsoleColor.Yellow);
            typewriter.Type("There's a gun to your head", fastSpeed);
            Thread.Sleep(400);
            typewriter.Type("and death in his eyes,", fastSpeed);
            Thread.Sleep(400);
            typewriter.Type("but you can do jiu-jitsuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu and you bodyslam superstar", fastSpeed);
            PrintShiaArt(gameData.Shia4, ConsoleColor.Red);
            typewriter.Type("Legendary fight with", moderateSpeed);
            PrintShiaArt(gameData.Shia5, ConsoleColor.Red);
            typewriter.Type("normal Tuesday night for", moderateSpeed);
            PrintShiaArt(gameData.Shia6, ConsoleColor.Red);
            typewriter.Type("He’s dodging every swipe, he parries to the left, you counter to the right, you catch him in the neck. You have just decapitated", fastSpeed);
            PrintShiaArt(gameData.Shia7, ConsoleColor.DarkYellow);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(gameData.confetti);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            typewriter.Type("His head topples to the floor, expressionless. You are finally safe... from", slowSpeed);
            PrintShiaArt(gameData.Shia8, ConsoleColor.Red);
        }
    }
}

// To call this scene:
// TestDescription testDecription = new TestDescription();
// testDecription.PlayDarkWoodsScene_Victory();