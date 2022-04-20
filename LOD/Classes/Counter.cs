using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class Counter
    {
        public static int mountain_top { get; set; } = 0;
        public static int temple_door { get; set; } = 0;
        public static int read_the_wall { get; set; } = 0;
        public static int open_door { get; set; } = 0;
        public static int forest_entrance { get; set; } = 0;
        public static int forest_village { get; set; } = 0;
        public static int dojo { get; set; } = 0;
        public static int open_mind { get; set; } = 0;
        public static int dark_woods { get; set; } = 0;
        public static int desert { get; set; } = 0;
        public static int desert_wall { get; set; } = 0;
        public static int desert_village { get; set; } = 0;
        public static int rock_game { get; set; } = 0;
        public static int icy_tundra { get; set; } = 0;
        public static int ravine { get; set; } = 0;
        public static int shelobs_lair { get; set; } = 0;
        public static int castle_entrance { get; set; } = 0;
        public static int skeleton_room { get; set; } = 0;
        public static int throne_room { get; set; } = 0;

        public void Reset()
        {
            mountain_top = 0;
            temple_door = 0;
            read_the_wall = 0;
            open_door = 0;
            forest_entrance = 0;
            forest_village = 0;
            dojo = 0;
            dark_woods = 0;
            desert = 0;
            desert_wall = 0;
            desert_village = 0;
            rock_game = 0;
            icy_tundra = 0;
            ravine = 0;
            shelobs_lair = 0;
            castle_entrance = 0;
            skeleton_room = 0;
            throne_room = 0;
        }
    }
}
