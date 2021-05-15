namespace Iterator
{
    public interface IIterator<T>
    {
        T Current();
        bool HasNext();
        void Next();
    }
}