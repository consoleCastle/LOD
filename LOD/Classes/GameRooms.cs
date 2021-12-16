using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class GameRooms
    {
        public Room mountain_top = new Room("mountain_top", "A small courtyard atop of a mountain. There is an ancient temple in front of you and there are three paths down the mountain. One leads to a massive green forest, one leads to a rocky hot desert and one leads to a bleak icy tundra. You notice a stone in the corner of the courtyard with a message carved into it… ‘dallen was here’. Where will you go?\n");
        public Room temple_door = new Room("temple_door", "Dust and cobwebs cover everything, this place is very old. There is a massive stone door and ancient writing on the wall. What will you do?\n");
        public Room forest_entrance = new Room("forest_entrance", "You have entered a lush and peaceful forest… yet you can’t shake the feeling that you are being watched. You can see a tree village deeper in the forest. You also see a path leading back up the mountain.\n");
        public Room desert = new Room("desert", "You stand upon the sand dunes of the desert. The sun overhead is very hot and you are parched, you had better get moving soon. There is a pathway leading back up to the top of the mountain behind you. Ahead of you, in the distance you see a large wall encircling what seems like an abandoned village.\n");
        public Room icy_tundra = new Room("icy_tundra", "");
        public Room read_the_wall = new Room("read_the_wall", "The wall reads: ‘Before time began and before spirits and life existed, the universe was in chaos. Then, three Golden Goddesses descended upon the chaos and began the creation of the world, each of them creating a different facet of the realm. Din created the material realm, Nayru gave the realm law and order, and Farore created all life forms that would follow the order. When their labors completed, the Goddesses departed for the heavens leaving behind three sacred stones, each representing a small portion of the essence of the goddesses.’ You notice a pedestal before the great stone door with three empty divots in it.\n");
        public Room open_door = new Room("open_door", "The great stone door cracks open slowly to a heavenly bright light. You step over the threshold. You have escaped the strange world!\n");
        public Room forest_village = new Room("forest_village", "A peaceful village of forest elves lives in the trees! Their elder approaches you: ‘Greetings traveler, welcome to our village. Magic stones you say? Yes I have one, I would be willing to give it to you if you can defeat the monster in the dark woods that has been terrorizing my people. I recommend Jiu-Jitsu training from our local dojo.\n");
        public Room dark_woods = new Room("dark_woods", "placeholder\n");
        public Room dojo = new Room("dojo", "You enter the school. There are many students in white uniforms punching logs and throwing rocks. The sensei approaches you: ‘IF YOU CAN DODGE A ROCK, YOU CAN BODY SLAM A MONSTER!’ She hurls a rock into your stomach and you double over in pain. She is disappointed, and your training begins. You push yourself through an 80’s style training montage and become slightly more proficient in Jiu-Jitsu.\n");
        public Room open_mind_room = new Room("open_mind_room", "You must look within yourself to save yourself from your other self. Only then will your true self reveal itself.\n");
        public Room village_wall = new Room("village_wall", "");
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
            mountain_top.Options[3] = "Go to the Tundra (NOT YET BUILT)";

            temple_door.Options = new string[2];
            temple_door.Choices.Add("1", mountain_top);
            temple_door.Options[0] = "Go back outside";
            temple_door.Choices.Add("2", read_the_wall);
            temple_door.Options[1] = "Read the wall";

            read_the_wall.Options = new string[1];
            read_the_wall.Choices.Add("1", temple_door);
            read_the_wall.Options[0] = "Go back";

            forest_entrance.Options = new string[2];
            forest_entrance.Choices.Add("1", forest_village);
            forest_entrance.Options[0] = "Go to the village";
            forest_entrance.Choices.Add("2", mountain_top);
            forest_entrance.Options[1] = "Go back to the mountain";

            forest_village.Options = new string[3];
            forest_village.Choices.Add("1", forest_entrance);
            forest_village.Options[0] = "Go back to the forest entrance";
            forest_village.Choices.Add("2", dark_woods);
            forest_village.Options[1] = "Go into the dark woods";
            forest_village.Choices.Add("3", dojo);
            forest_village.Options[2] = "Go into the dojo";

            dojo.Options = new string[2];
            dojo.Choices.Add("1", forest_village);
            dojo.Options[0] = "Go back to the village";

            open_mind_room.Options = new string[1];
            open_mind_room.Choices.Add("1", forest_village);
            open_mind_room.Options[0] = "Go back to the village";

            dark_woods.Options = new string[1];
            dark_woods.Choices.Add("1", forest_village);
            dark_woods.Options[0] = "Go back to the village";

            desert.Options = new string[2];
            desert.Choices.Add("1", mountain_top);
            desert.Options[0] = "Go back to the mountain";
            desert.Choices.Add("2", village_wall);
            desert.Options[1] = "Go to the wall";
        }
    }
}
