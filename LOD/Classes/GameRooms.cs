using System;
using System.Collections.Generic;
using System.Text;
using LOD.Tools;


namespace LOD.Classes
{
    class GameRooms
    {
        public Room mountain_top = new Room(
            "mountain_top",
            "A small courtyard atop of a mountain. There is an ancient temple in front of you and there are three paths down the mountain. One leads to a massive green forest, one leads to a rocky hot desert and one leads to a bleak icy tundra. You notice a stone in the corner of the courtyard with a message carved into it… ‘dallen was here’. Where will you go?\n",
            new List<string>
            {
                "Go to the Temple",
                "Go to the Forest",
                "Go to the Desert",
                "Go to the Icy Tundra (NOT YET BUILT)"
            }
        );
        public Room temple_door = new Room(
            "temple_door", 
            "Dust and cobwebs cover everything, this place is very old. There is a massive stone door and ancient writing on the wall. What will you do?\n",
            new List<string>
            {
                "Go back outside",
                "Read the wall"
            }
        );
        public Room forest_entrance = new Room(
            "forest_entrance", 
            "You have entered a lush and peaceful forest… yet you can’t shake the feeling that you are being watched. You can see a tree village deeper in the forest. You also see a path leading back up the mountain.\n",
            new List<string>
            {
                "Go to the Village",
                "Go back to the Mountain"
            }
        );
        public Room desert = new Room(
            "desert", 
            "You stand upon the sand dunes of the desert. The sun overhead is very hot and you are parched, you had better get moving soon. There is a pathway leading back up to the top of the mountain behind you. Ahead of you, in the distance you see a large wall encircling what seems like an abandoned village.\n",
            new List<string>
            {
                "Go back to the Mountain",
                "Go to the wall"
            }
        );
        public Room icy_tundra = new Room(
            "icy_tundra", 
            ""
        );
        public Room read_the_wall = new Room(
            "read_the_wall", 
            "The wall reads: ‘Before time began and before spirits and life existed, the universe was in chaos. Then, three Golden Goddesses descended upon the chaos and began the creation of the world, each of them creating a different facet of the realm. Din created the material realm, Nayru gave the realm law and order, and Farore created all life forms that would follow the order. When their labors completed, the Goddesses departed for the heavens leaving behind three sacred stones, each representing a small portion of the essence of the goddesses.’ You notice a pedestal before the great stone door with three empty divots in it.\n",
            new List<string>
            {
                "Go back"
            }
        );
        public Room open_door = new Room(
            "open_door", 
            "The great stone door cracks open slowly to a heavenly bright light. You step over the threshold. You have escaped the strange world!\n"
        );
        public Room forest_village = new Room(
            "forest_village", 
            "A peaceful village of forest elves lives in the trees! Their elder approaches you: ‘Greetings traveler, welcome to our village. Magic stones you say? Yes I have one, I would be willing to give it to you if you can defeat the monster in the dark woods that has been terrorizing my people. I recommend Jiu-Jitsu training from our local dojo.\n",
            new List<string>
            {
                "Go back to the Forest Entrance",
                "Go into the Dark Woods",
                "Go into the Dojo"
            }
        );
        public Room dark_woods = new Room(
            "dark_woods", 
            "placeholder\n",
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room dojo = new Room(
            "dojo", 
            "You enter the school. There are many students in white uniforms punching logs and throwing rocks. The sensei approaches you: ‘IF YOU CAN DODGE A ROCK, YOU CAN BODY SLAM A MONSTER!’ She hurls a rock into your stomach and you double over in pain. She is disappointed, and your training begins. You push yourself through an 80’s style training montage and become slightly more proficient in Jiu-Jitsu.\n",
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room open_mind_room = new Room(
            "open_mind_room", 
            "You must look within yourself to save yourself from your other self. Only then will your true self reveal itself.\n",
            new List<string>
            {
                "Go back to the Village"
            }
        );
        public Room village_wall = new Room(
            "village_wall",
            "A great stone wall looms over you. Through the village entrance, you can see what seems to be moving rocks scattered about the village. It may be a mirage? As you approach, an immense, iron-wrought gate crashes shut over the entrance with a CLANG. Atop the gate a man in chainmail armor and a well-groomed mustache appears. In an outrageous French accent, the man shouts down at you: ‘[RANDOMLY GENERATED TAUNT]’. The taunt cuts deep and you have no retort. The frustration is too much to bear and you feel that you must turn back to compose yourself.",
            new List<string>
            {
                "Go back to the desert",
                "Try to reason with the man"
            }
        );
        public Room taunt = new Room(
            "taunt",
            "The man taunts you",
            new List<string>
            {
                "Gather yourself and try again"
            }
        );
        public Room desert_village = new Room(
            "desert_village",
            "You walk among dilapidated buildings and several boulders that are randomly strewn about. Suddenly they come alive! It is a society of stone golems! Their leader approaches you:‘Hey.You look tasty.Want play game ? If win - you get good!’ He shows you the traditional game of his people.It’s called ‘take the last rock to win.’ The rules are pretty simple.",
            new List<string>
            {
                "Play the rock game",
                "Go back to the desert"
            }
            );
        public GameRooms()
        {
            mountain_top.Choices.Add("1", temple_door);
            mountain_top.Choices.Add("2", forest_entrance);
            mountain_top.Choices.Add("3", desert);
            mountain_top.Choices.Add("4", icy_tundra);

            temple_door.Choices.Add("1", mountain_top);
            temple_door.Choices.Add("2", read_the_wall);

            read_the_wall.Choices.Add("1", temple_door);

            forest_entrance.Choices.Add("1", forest_village);
            forest_entrance.Choices.Add("2", mountain_top);

            forest_village.Choices.Add("1", forest_entrance);
            forest_village.Choices.Add("2", dark_woods);
            forest_village.Choices.Add("3", dojo);

            dojo.Choices.Add("1", forest_village);

            open_mind_room.Choices.Add("1", forest_village);

            dark_woods.Choices.Add("1", forest_village);

            desert.Choices.Add("1", mountain_top);
            desert.Choices.Add("2", village_wall);

            village_wall.Choices.Add("1", desert);
            village_wall.Choices.Add("2", taunt);

            taunt.Choices.Add("1", village_wall);
        }
    }
}
