namespace DotNetDigestCodeSamples.Stack;

public class CustomStack<T>
{
    private readonly List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        return items[items.Count - 1];
    }

    public bool IsEmpty() => items.Count == 0;

    public int Count => items.Count;
}