namespace EGenericStack;

internal class SeStack<T> 
{
    List<T> data = new List<T>();

    public void Push(T value)
    {
        data.Add(value);
    }

    public T Pop()
    {
        T result = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);
        return result;
    }
}

