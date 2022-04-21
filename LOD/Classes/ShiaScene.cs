using System;
using System.Threading;
using LOD.Interfaces;
using LOD.Tools;
using LOD.Utils;

namespace LOD.Classes
{
    class ShiaScene : IShiaScene
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

        public void PrintContinueMsg()
        {
            Typewriter typewriter = new Typewriter();

            typewriter.GiveMeSpace();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press ANY KEY to continue.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string Defeat()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            string defeatMsg = "You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,\n"
                + art.Shia1 + 
                "\nHe’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!\n"
                + art.Shia2 + 
                "\nYou try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face and\nAHHH!\nYour leg!\nIt's caught in a bear trap!\n Press ANY KEY to continue.";

            Console.Clear();
            try
            {
                typewriter.Type("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed, true, true);
                PrintShiaArt(art.Shia1, ConsoleColor.Red);
                typewriter.Type("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed, true, true);
                PrintShiaArt(art.Shia2, ConsoleColor.Red);
                typewriter.Type("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face and", fastSpeed, true, true);
                typewriter.Type("AHH!", fastSpeed, true, true);
                Thread.Sleep(300);
                typewriter.Type("Your Leg!", fastSpeed, true, true);
                Thread.Sleep(300);
                typewriter.Type("It's caught in a bear trap!", fastSpeed, true, true);
                PrintContinueMsg();
                Console.ReadLine();
                return "You are eaten by ACTUAL CANNIBAL Shia LeBeuof.";
            }
            catch
            {
                Console.WriteLine(defeatMsg);
                Console.ReadLine();
                return "You are eaten by ACTUAL CANNIBAL Shia LeBeuof.";
            }
        }
        public string Victory()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            string victoryMsg = "You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,\n"
                + art.Shia1 +
                "\nHe’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!\n"
                + art.Shia2 +
                "\nYou try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face, MY GOD there's blood EVERYWHERE! Acting on raw instinct, you wrestle a knife from Hollywood’s\n"
                + art.Shia3 +
                "\nSlicing downwards you are able to stab him in his kidney. After a horrific gasp, he falls to the ground, dead.\nWAIT! He isn't dead!\n"
                + art.ShiaSurprise +
                "\nThere's a gun to your head- and death in his eyes, but you can do jiu-jitsuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu and you bodyslam superstar\n"
                + art.Shia4 +
                "\nLegendary fight with\n"
                + art.Shia5 +
                "\nnormal Tuesday night for\n"
                + art.Shia6 +
                "\nHe’s dodging every swipe, he parries to the left, you counter to the right, you catch him in the neck. You have just decapitated\n"
                + art.Shia7 + "\n"
                + art.Confetti +
                "\nHis head topples to the floor, expressionless. You are finally safe... from\n"
                + art.Shia8 +
                "\nFrom behind you the village elder appears. He exclaims, ‘Thank you for saving us from that ancient evil. Take this stone as a token of our eternal gratitude!' You receive an emerald stone that softly shines with the warmth of a summer forest. As you hold it a pleasant wind blows.\n"
                + "Press ANY KEY to Continue.";

            Console.Clear();
            try
            {
                typewriter.Type("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed, false, true);
                PrintShiaArt(art.Shia1, ConsoleColor.Red);
                typewriter.Type("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed, true, true);
                PrintShiaArt(art.Shia2, ConsoleColor.Red);
                typewriter.Type("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face,", fastSpeed, true, true);
                Thread.Sleep(300);
                typewriter.Type("MY GOD there's blood EVERYWHERE!", fastSpeed, true, true);
                Thread.Sleep(500);
                typewriter.Type("Acting on raw instinct, you wrestle a knife from Hollywood’s", moderateSpeed, true, true);
                PrintShiaArt(art.Shia3, ConsoleColor.Red);
                typewriter.Type("Slicing downwards you are able to stab him in his kidney.", moderateSpeed, true, true);
                Thread.Sleep(300);
                typewriter.Type("After a horrific gasp, he falls to the ground, dead.", slowSpeed, true, true);
                Thread.Sleep(1100);
                Console.Clear();
                typewriter.Type("It's Over...", slowSpeed, true, true);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("*  <<< Go Back to forest entrance >>>");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(8000);
                Console.ForegroundColor = ConsoleColor.Red;
                typewriter.Type("WAIT!", moderateSpeed, true, true);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(300);
                typewriter.Type("He isn't dead!!", fastSpeed, true, true);
                PrintShiaArt(art.ShiaSurprise, ConsoleColor.Yellow);
                typewriter.Type("There's a gun to your head", fastSpeed, true, true);
                Thread.Sleep(400);
                typewriter.Type("and death in his eyes,", fastSpeed, true, true);
                Thread.Sleep(400);
                typewriter.Type("but you can do jiu-jitsuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu and you bodyslam superstar", fastSpeed, true, true);
                PrintShiaArt(art.Shia4, ConsoleColor.Red);
                typewriter.Type("Legendary fight with", moderateSpeed, true, true);
                PrintShiaArt(art.Shia5, ConsoleColor.Red);
                typewriter.Type("normal Tuesday night for", moderateSpeed, true, true);
                PrintShiaArt(art.Shia6, ConsoleColor.Red);
                typewriter.Type("He’s dodging every swipe, he parries to the left, you counter to the right, you catch him in the neck. You have just decapitated", fastSpeed, true, true);
                PrintShiaArt(art.Shia7, ConsoleColor.DarkYellow);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(art.Confetti);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                typewriter.Type("His head topples to the floor, expressionless. You are finally safe... from", slowSpeed, true, true);
                PrintShiaArt(art.Shia8, ConsoleColor.Red);
                PrintContinueMsg();
                Console.ReadLine();
                return "From behind you the village elder appears. He exclaims, ‘Thank you for saving us from that ancient evil. Take this stone as a token of our eternal gratitude!' You receive an emerald stone that softly shines with the warmth of a summer forest. As you hold it a pleasant wind blows.";
            }
            catch
            {
                Console.WriteLine(victoryMsg);
                Console.ReadLine();
                return "From behind you the village elder appears. He exclaims, ‘Thank you for saving us from that ancient evil. Take this stone as a token of our eternal gratitude!' You receive an emerald stone that softly shines with the warmth of a summer forest. As you hold it a pleasant wind blows.";
            }
        }
    }
}
