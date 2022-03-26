namespace Iterator_Pattern
{
    public interface IIterator
    {
        bool HasNext();
        void Next();
        string Current();

    }
}
