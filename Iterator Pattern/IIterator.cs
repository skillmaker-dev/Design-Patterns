namespace Iterator_Pattern
{
    public interface IIterator<T>
    {
        bool HasNext();
        void Next();
        T Current();

    }
}
