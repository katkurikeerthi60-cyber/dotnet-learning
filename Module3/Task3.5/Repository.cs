namespace Task3_5;

public class Repository<T>
{
    private List<T> items = new List<T>();

    public event Action<T>? ItemAdded;

    public void Add(T item)
    {
        items.Add(item);
        ItemAdded?.Invoke(item);
    }

    public List<T> Get()
    {
        return items;
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }
}
