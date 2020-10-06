namespace DS
{
    public interface IIterator<T>
    {
        T GetNext();
        bool HasMore();
    }
}
