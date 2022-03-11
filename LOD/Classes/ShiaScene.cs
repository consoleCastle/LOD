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

        public string Defeat()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            Console.Clear();
            typewriter.TypeWithoutSkipMsg("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed);
            PrintShiaArt(art.Shia1, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed);
            PrintShiaArt(art.Shia2, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face and", fastSpeed);
            typewriter.TypeWithoutSkipMsg("AHH!", fastSpeed);
            Thread.Sleep(300);
            typewriter.TypeWithoutSkipMsg("Your Leg!", fastSpeed);
            Thread.Sleep(300);
            typewriter.TypeWithoutSkipMsg("It's caught in a bear trap!", fastSpeed);
            return "You are eaten by ACTUAL CANNIBAL Shia LeBeuof.";
        }
        public string DefeatSkip()
        {
            Typewriter typewriter = new Typewriter();
            string defeatMsg = "You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,\nSHIA LEBEUOF\nHe’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!\nSHIA LEBEUOF\nYou try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face and\nAHHH!\nYour leg!\nIt's caught in a bear trap!";
            Console.Clear();
            typewriter.skipWithLineBreaks(0, defeatMsg);
            Thread.Sleep(8000);
            return "You are eaten by ACTUAL CANNIBAL Shia LeBeuof.";
        }
        public string Victory()
        {
            Typewriter typewriter = new Typewriter();
            int slowSpeed = (int)Typewriter.Speed.slow;
            int moderateSpeed = (int)Typewriter.Speed.moderate;
            int fastSpeed = (int)Typewriter.Speed.fast;

            Console.Clear();
            typewriter.TypeWithoutSkipMsg("You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,", slowSpeed);
            PrintShiaArt(art.Shia1, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("He’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!", moderateSpeed);
            PrintShiaArt(art.Shia2, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("You try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face,", fastSpeed);
            Thread.Sleep(300);
            typewriter.TypeWithoutSkipMsg("MY GOD there's blood EVERYWHERE!", fastSpeed);
            Thread.Sleep(500);
            typewriter.TypeWithoutSkipMsg("Acting on raw instinct, you wrestle a knife from Hollywood’s", moderateSpeed);
            PrintShiaArt(art.Shia3, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("Slicing downwards you are able to stab him in his kidney.", moderateSpeed);
            Thread.Sleep(300);
            typewriter.TypeWithoutSkipMsg("After a horrific gasp, he falls to the ground, dead.", slowSpeed);
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
            typewriter.TypeWithoutSkipMsg("WAIT!", moderateSpeed);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(300);
            typewriter.TypeWithoutSkipMsg("He isn't dead!!", fastSpeed);
            PrintShiaArt(art.ShiaSurprise, ConsoleColor.Yellow);
            typewriter.TypeWithoutSkipMsg("There's a gun to your head", fastSpeed);
            Thread.Sleep(400);
            typewriter.TypeWithoutSkipMsg("and death in his eyes,", fastSpeed);
            Thread.Sleep(400);
            typewriter.TypeWithoutSkipMsg("but you can do jiu-jitsuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu and you bodyslam superstar", fastSpeed);
            PrintShiaArt(art.Shia4, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("Legendary fight with", moderateSpeed);
            PrintShiaArt(art.Shia5, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("normal Tuesday night for", moderateSpeed);
            PrintShiaArt(art.Shia6, ConsoleColor.Red);
            typewriter.TypeWithoutSkipMsg("He’s dodging every swipe, he parries to the left, you counter to the right, you catch him in the neck. You have just decapitated", fastSpeed);
            PrintShiaArt(art.Shia7, ConsoleColor.DarkYellow);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(art.confetti);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            typewriter.TypeWithoutSkipMsg("His head topples to the floor, expressionless. You are finally safe... from", slowSpeed);
            PrintShiaArt(art.Shia8, ConsoleColor.Red);
            return "From behind you the village elder appears. He exclaims, ‘Thank you for saving us from that ancient evil. Take this stone as a token of our eternal gratitude!'";
        }
        public string VictorySkip()
        {
            Typewriter typewriter = new Typewriter();

            Console.Clear();
            string victoryMsg1 = "You’re walking in the woods. There’s no one around and your phone is dead. Out of the corner of your eye you spot him,\nSHIA LEBEUOF\nHe’s following you, about thirty feet back. He gets down on all fours and breaks into a sprint. He’s gaining on you!\nSHIA LEBEUOF\nYou try to find your way but you’re all turned around. He’s almost upon you now and you can see there's blood on his face, MY GOD there's blood EVERYWHERE! Acting on raw instinct, you wrestle a knife from Hollywood’s\nSHIA LEBEUOF\nSlicing downwards you are able to stab him in his kidney. After a horrific gasp, he falls to the ground, dead.";
            string victoryMsg2 = "WAIT! He isn't dead!\nSHIA SURPRISE!!!!\nThere's a gun to your head- and death in his eyes, but you can do jiu-jitsuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu and you bodyslam superstar\nSHIA LEBEUOF\nLegendary fight with\nSHIA LEBEUOF\nnormal Tuesday night for\nSHIA LEBEUOF\nHe’s dodging every swipe, he parries to the left, you counter to the right, you catch him in the neck. You have just decapitated\nSHIA LEBEUOF!!!!!!!\nHis head topples to the floor, expressionless. You are finally safe... from\nSHIA.....Lebeouf";
            typewriter.skipWithLineBreaks(0, victoryMsg1);
            Console.WriteLine("It's Over...");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*  <<< Go Back to forest entrance >>>");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(8000);
            typewriter.skipWithLineBreaks(0, victoryMsg2);
            return "From behind you the village elder appears. He exclaims, ‘Thank you for saving us from that ancient evil. Take this stone as a token of our eternal gratitude!'";
        }
    }
}

// To call this scene:
// ShiaScene shiaScene = new ShiaScene();
// shiaScene.Victory();