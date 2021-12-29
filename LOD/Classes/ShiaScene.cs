using System;
using System.Threading;
using LOD.Tools;
using LOD.Utils;

namespace LOD.Classes
{
    class ShiaScene
    {
        AsciiArt art = new AsciiArt();

        public void PrintShiaArt(string shiaArt, ConsoleColor color)
        {
            Thread.Sleep(500);
            Console.ForegroundColor = color;
            Console.WriteLine(shiaArt);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(900);
        }

        public string Defeat()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            Console.Clear();
            typewriter.Type("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed);
            PrintShiaArt(art.Shia1, ConsoleColor.Red);
            typewriter.Type("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed);
            PrintShiaArt(art.Shia2, ConsoleColor.Red);
            typewriter.Type("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face and", fastSpeed);
            typewriter.Type("AHH!", fastSpeed);
            Thread.Sleep(300);
            typewriter.Type("Your Leg!", fastSpeed);
            Thread.Sleep(300);
            typewriter.Type("It's caught in a bear trap!", fastSpeed);
            return "You are eaten by ACTUAL CANNIBAL Shia LeBeuof.";
        }
        public string Victory()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            Console.Clear();
            typewriter.Type("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed);
            PrintShiaArt(art.Shia1, ConsoleColor.Red);
            typewriter.Type("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed);
            PrintShiaArt(art.Shia2, ConsoleColor.Red);
            typewriter.Type("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face,", fastSpeed);
            Thread.Sleep(300);
            typewriter.Type("MY GOD there's blood EVERYWHERE!", fastSpeed);
            Thread.Sleep(500);
            typewriter.Type("Acting on raw instinct, you wrestle a knife from Hollywood’s", moderateSpeed);
            PrintShiaArt(art.Shia3, ConsoleColor.Red);
            typewriter.Type("Slicing downwards you are able to stab him in his kidney.", moderateSpeed);
            Thread.Sleep(300);
            typewriter.Type("After a horrific gasp, he falls to the ground, dead.", slowSpeed);
            Thread.Sleep(1100);
            Console.Clear();
            Console.WriteLine("It's Over...");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*  <<< Go Back to forest entrance >>>");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(8000);
            Console.ForegroundColor = ConsoleColor.Red;
            typewriter.Type("WAIT!", moderateSpeed);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(300);
            typewriter.Type("He isn't dead!!", fastSpeed);
            PrintShiaArt(art.ShiaSurprise, ConsoleColor.Yellow);
            typewriter.Type("There's a gun to your head", fastSpeed);
            Thread.Sleep(400);
            typewriter.Type("and death in his eyes,", fastSpeed);
            Thread.Sleep(400);
            typewriter.Type("but you can do jiu-jitsuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu and you bodyslam superstar", fastSpeed);
            PrintShiaArt(art.Shia4, ConsoleColor.Red);
            typewriter.Type("Legendary fight with", moderateSpeed);
            PrintShiaArt(art.Shia5, ConsoleColor.Red);
            typewriter.Type("normal Tuesday night for", moderateSpeed);
            PrintShiaArt(art.Shia6, ConsoleColor.Red);
            typewriter.Type("He’s dodging every swipe, he parries to the left, you counter to the right, you catch him in the neck. You have just decapitated", fastSpeed);
            PrintShiaArt(art.Shia7, ConsoleColor.DarkYellow);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(art.confetti);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            typewriter.Type("His head topples to the floor, expressionless. You are finally safe... from", slowSpeed);
            PrintShiaArt(art.Shia8, ConsoleColor.Red);
            return "From behind you the village elder appears. He exclaims, ‘Thank you for saving us from that ancient evil. Take this stone as a token of our eternal gratitude!'";
        }
    }
}

// To call this scene:
// ShiaScene shiaScene = new ShiaScene();
// shiaScene.Victory();