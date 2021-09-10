using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class EndType
    {
        public bool IsGameover { get; set; } = false;
        public string CauseMessage { get; set; } = "";

        // This is how you use this endtype with the End function in play game/ likely this will be used in the room sequence functionality
/*      EndType newEnd = new EndType();
        newEnd.IsGameover = true;
        newEnd.CauseMessage = "This is a test Gameover message";

        PlayGame.End(newEnd);*/
    }
}
