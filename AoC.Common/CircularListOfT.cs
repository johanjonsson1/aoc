namespace AoC.Common;

public class CircularList<T>
{
    public List<T> Items { get; }

    public CircularList()
    {
        Items = new List<T>();
    }

    public CircularList(IEnumerable<T> items)
    {
        Items = new List<T>(items);
    }

    public CircularList(int capacity = 0)
    {
        Items = new List<T>(capacity);
    }

    public void Add(T item)
    {
        Items.Add(item);
    }

    public void Insert(int index, T item)
    {
        Items.Insert(index, item);
    }

    public int GetNext(int currentIndex, int steps)
    {
        currentIndex = (currentIndex + steps) % Items.Count;

        return currentIndex;
    }

    public int GetPrevious(int currentIndex, int steps)
    {
        for (var i = 0; i < steps; i++)
        {
            currentIndex = PreviousIndex(currentIndex);
        }

        return currentIndex;
    }

    public int NextIndex(int index)
    {
        index++;
        index %= Items.Count;

        return index;
    }

    public int PreviousIndex(int index)
    {
        index--;
        if (index < 0)
        {
            index = Items.Count - 1;
        }

        return index;
    }

    public T this[int i]
    {
        get => Items[i % Items.Count];
        set => Items[i % Items.Count] = value;
    }
}