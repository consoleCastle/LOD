using System.Collections.Generic;

namespace LOD.Interfaces
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        List<string> Options { get; set; }
    }
}
