public class Queue<T>
{
    private T[] items;
    private int head;
    private int tail;
    private int count;
    private const int DefaultCapacity = 4;

    public Queue(int capacity = DefaultCapacity)
    {
        items = new T[capacity];
        head = 0;
        tail = 0;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (count == items.Length)
        {
            Resize();
        }

        items[tail] = item;
        tail = (tail + 1) % items.Length;
        count++;
    }

    public T Dequeue()
    {
        if (isEmpty)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        T item = items[head];
        head = (head + 1) % items.Length;
        count--;
        return item;
    }

    public T Peek()
    {
        if (isEmpty)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return items[head];
    }

    public void Resize()
    {
        T[] newItems = new T[items.Length * 2];
        if (head < tail)
        {
            Array.Copy(items, head, newItems, 0, count);
        }
        else
        {
            Array.Copy(items, head, newItems, 0, items.Length - head);
            Array.Copy(items, 0, newItems, items.Length - head, tail);
        }
        items = newItems;
        head = 0;
        tail = count;
    }

    public void Clear()
    {
        Array.Clear(items, 0, count);
        head = 0;
        tail = 0;
        count = 0;
    }

    public bool isEmpty => count == 0;
    public int Count => count;

}