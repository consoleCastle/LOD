namespace LOD.Interfaces
{
    public interface IPlayerFlags
    {
        bool Three_Stones_Collected { get; set; }
        bool Farores_Wind_Collected { get; set; }
        bool Dins_Fire_Collected { get; set; }
        bool Nayrus_Love_Collected { get; set; }
        bool Shia_Defeated { get; set; }
        bool Slightly_JiuJitsu_Proficient { get; set; }
        bool Open_Mind { get; set; }
        bool Rock_Champion { get; set; }
        void Reset();
    }
}
