namespace DS
{
    public interface IIterable<T>
    {
        IIterator<T> GetIterator();
    }
}
