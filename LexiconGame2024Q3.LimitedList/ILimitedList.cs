
namespace LexiconGame2024Q3.LimitedList
{
    public interface ILimitedList<T> : IEnumerable<T>
    {
        T this[int index] { get; }

        int Count { get; }
        bool IsFull { get; }

        bool Add(T item);
        //IEnumerator<T> GetEnumerator();
        void Print(Action<T> action);
        bool Remove(T item);
    }
}