namespace LOD.Interfaces
{
    public interface ITypewriter
    {
        void Type(string message, int speed);
        void TypeWithoutSkipMsg(string message, int speed);
        void GiveMeSpace();
        void Skip(string message);
        void LetUserKnowTheyCanSkip();
        void TypeWithLineBreaks(int indexStart, string message, int speed);
        void skipWithLineBreaks(int indexStart, string message);
    }
}
