using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class EndType
    {
        public bool IsGameover { get; set; } = false;
        public bool IsGoodEnding { get; set; } = false;
        public string CauseMessage { get; set; } = "";
    }
}
