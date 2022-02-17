using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class Counter
    {
        public int mountain_top { get; set; } = 0;
        public int temple_door { get; set; } = 0;
        public int read_the_wall { get; set; } = 0;
        public int open_door { get; set; } = 0;
        public int forest_entrance { get; set; } = 0;
        public int forest_village { get; set; } = 0;
        public int dojo { get; set; } = 0;
        public int dark_woods { get; set; } = 0;
        public int desert { get; set; } = 0;
        public int desert_wall { get; set; } = 0;
        public int desert_village { get; set; } = 0;
        public int rock_game { get; set; } = 0;
        public int icy_tundra { get; set; } = 0;
        public int castle_entrance { get; set; } = 0;
        public int skeleton_room { get; set; } = 0;
        public int spider_room { get; set; } = 0;
        public int throne_room { get; set; } = 0;

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
            castle_entrance = 0;
            skeleton_room = 0;
            spider_room = 0;
            throne_room = 0;
        }
    }
}
