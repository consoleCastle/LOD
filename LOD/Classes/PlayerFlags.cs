﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class PlayerFlags
    {
        public bool Three_Stones_Collected { get; set; }
        public bool Farores_Wind_Collected { get; set; }
        public bool Dins_Fire_Collected { get; set; }
        public bool Nayrus_Love_Collected { get; set; }
        public bool Shia_Surprise { get; set; }
        public bool Slightly_JiuJitsu_Proficient { get; set; }
        public bool Open_Mind { get; set; }
        public bool Rock_Champion { get; set; }

        public void Reset()
        {
            Shia_Surprise = true;

            Three_Stones_Collected = false;
            Farores_Wind_Collected = false;
            Dins_Fire_Collected = false;
            Nayrus_Love_Collected = false;
            Slightly_JiuJitsu_Proficient = false;
            Open_Mind = false;
            Rock_Champion = false;
        }
    }
}