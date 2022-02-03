using System;

namespace LOD.Interfaces
{
    public interface IShiaScene
    {
        void PrintShiaArt(string shiaArt, ConsoleColor color);
        string Defeat();
        string Victory();
    }
}
