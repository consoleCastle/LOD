using System;
using System.Collections.Generic;
using System.Text;
using LOD.Tools;


namespace LOD.Classes
{
    class GameRooms
    {
        public Room mountain_top = new Room("mountain_top", "A small courtyard atop of a mountain. There is an ancient temple in front of you and there are three paths down the mountain. One leads to a massive green forest, one leads to a rocky hot desert and one leads to a bleak icy tundra. You notice a stone in the corner of the courtyard with a message carved into it… ‘dallen was here’. Where will you go?");
        public Room temple_door = new Room("temple_door", "Dust and cobwebs cover everything, this place is very old. There is a massive stone door and ancient writing on the wall. What will you do?");
        public Room forest_entrance = new Room("forest_entrance", "You have entered a lush and peaceful forest… yet you can’t shake the feeling that you are being watched. You can see a tree village deeper in the forest. You also see a path leading back up the mountain.");
        public Room desert = new Room("desert", "You stand upon the sand dunes of the desert. The sun overhead is very hot and you are parched, you had better get moving soon. There is a pathway leading back up to the top of the mountain behind you. Ahead of you, in the distance you see a large wall encircling what seems like an abandoned village.");
        public Room icy_tundra = new Room("icy_tundra", "");
        public Room read_the_wall = new Room("read_the_wall", "TODO: print creation myth and reveal objective to the player");
        public Room open_door = new Room("open_door", "The great stone door cracks open slowly to a heavenly bright light. You step over the threshold. You have escaped the strange world!");
        public Room forest_vilage = new Room("forest_village", "A peaceful village of forest elves lives in the trees! Their elder approaches you: ‘Greetings traveler, welcome to our village. Magic stones you say? Yes I have one, I would be willing to give it to you if you can defeat the monster in the dark woods that has been terrorizing my people. I recommend Jiu-Jitsu training from our local dojo.");
        public Room dark_woods = new Room("dark_woods", "TODO: defeated by shia sequence");
        public Room dojo = new Room("dojo", "You enter the school. There are many students in white uniforms punching logs and throwing rocks. The sensei approaches you: ‘IF YOU CAN DODGE A ROCK, YOU CAN BODY SLAM A MONSTER!’ She hurls a rock into your stomach and you double over in pain. She is disappointed, and your training begins. You push yourself through an 80’s style training montage and become slightly more proficient in Jiu-Jitsu.");
        public Room open_mind_room = new Room("open_mind_room", "You must look within yourself to save yourself from your other self. Only then will your true self reveal itself.");
        public Room vilage_wall = new Room("vilage_wall", $"A great stone wall looms over you. Through the village entrance, you can see what seems to be moving rocks scattered about the village. It may be a mirage? As you approach, an immense, iron-wrought gate crashes shut over the entrance with a CLANG. Atop the gate a man in chainmail armor and a well-groomed mustache appears. In an outrageous French accent, the man shouts down at you: ‘{TauntGenerator.Taunt()}’. The taunt cuts deep and you have no retort. The frustration is too much to bear and you feel that you must turn back to compose yourself.");
        public Room taunt = new Room("taunt", "TODO: Insert random taunt here");
        public Room desert_vilage = new Room("desert_vilage", "");
        public GameRooms()
        {
            mountain_top.Options = new string[4];
            mountain_top.Choices.Add("1", temple_door);
            mountain_top.Options[0] = "Go to the temple";
            mountain_top.Choices.Add("2", forest_entrance);
            mountain_top.Options[1] = "Go to the Forest";
            mountain_top.Choices.Add("3", desert);
            mountain_top.Options[2] = "Go to the Desert";
            mountain_top.Choices.Add("4", icy_tundra);
            mountain_top.Options[3] = "Go to the Tundra";

            temple_door.Options = new string[2];
            temple_door.Choices.Add("1", mountain_top);
            temple_door.Options[0] = "Go back outside";
            temple_door.Choices.Add("2", read_the_wall);
            temple_door.Options[1] = "Read the wall";

            read_the_wall.Options = new string[1];
            read_the_wall.Choices.Add("1", temple_door);
            read_the_wall.Options[0] = "Go back";

            forest_entrance.Options = new string[2];
            forest_entrance.Choices.Add("1", forest_vilage);
            forest_entrance.Options[0] = "Go to the village";
            forest_entrance.Choices.Add("2", mountain_top);
            forest_entrance.Options[1] = "Go back to the mountain";

            forest_vilage.Options = new string[3];
            forest_vilage.Choices.Add("1", forest_entrance);
            forest_vilage.Options[0] = "Go back to the forest entrance";
            forest_vilage.Choices.Add("2", dark_woods);
            forest_vilage.Options[1] = "Go into the dark woods";
            forest_vilage.Choices.Add("3", dojo);
            forest_vilage.Options[2] = "Go into the dojo";

            dojo.Options = new string[1];
            dojo.Choices.Add("1", forest_vilage);
            dojo.Options[0] = "Go back to the village";

            open_mind_room.Options = new string[1];
            open_mind_room.Choices.Add("1", forest_vilage);
            open_mind_room.Options[0] = "Go back to the village";

            dark_woods.Options = new string[1];
            dark_woods.Choices.Add("1", forest_vilage);
            dark_woods.Options[0] = "Go back to the village";

            desert.Options = new string[2];
            desert.Choices.Add("1", mountain_top);
            desert.Options[0] = "Go back to the mountain";
            desert.Choices.Add("2", vilage_wall);
            desert.Options[1] = "Go to the wall";

            vilage_wall.Options = new string[2];
            vilage_wall.Choices.Add("1", desert);
            vilage_wall.Options[0] = "Go back to the desert";
            vilage_wall.Choices.Add("2", taunt);
            vilage_wall.Options[1] = "Try to reason with the man";

            taunt.Options = new string[1];
            taunt.Choices.Add("1", vilage_wall);
            taunt.Options[0] = "Gather your wits and try again";
        }
    }
}
