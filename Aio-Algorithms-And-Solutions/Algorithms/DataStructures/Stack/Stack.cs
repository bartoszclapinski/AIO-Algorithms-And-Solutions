public class Stack<T>
{
    private T[] items;
    private int top;
    private const int DefaultCapacity = 4;

    public Stack(int capacity = DefaultCapacity)
    {
        items = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == items.Length - 1)
        {
            Resize();
        }
        items[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack is empty");
            
        return items[top--];
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack is empty");
            
        return items[top];
    }

    public bool IsEmpty => top == -1;
    
    public int Count => top + 1;

    private void Resize()
    {
        T[] newItems = new T[items.Length * 2];
        Array.Copy(items, newItems, items.Length);
        items = newItems;
    }
} 