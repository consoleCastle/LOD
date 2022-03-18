namespace LOD.Interfaces
{
    public interface ITypewriter
    {
        void Type(string message, int speed, bool hideSkip = false, bool isBrokenMsg = false);
        void GiveMeSpace();
        void Skip(string message);
        void LetUserKnowTheyCanSkip();
        void TypeWithLineBreaks(int indexStart, string message, int speed, bool isBrokenMsg = false);
        void skipWithLineBreaks(int indexStart, string message);
    }
}
