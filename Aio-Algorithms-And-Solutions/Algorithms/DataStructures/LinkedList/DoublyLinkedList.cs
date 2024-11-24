public class DoublyNode<T>
{
    public T Data { get; set; }
    public DoublyNode<T>? Next { get; set; }
    public DoublyNode<T>? Previous { get; set; }

    public DoublyNode(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

public class DoublyLinkedList<T>
{
    private DoublyNode<T>? head;
    private DoublyNode<T>? tail;
    public int Count { get; private set; }

    public void AddFirst(T data)
    {
        DoublyNode<T> newNode = new DoublyNode<T>(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }
        Count++;
    }

    public void AddLast(T data)
    {
        DoublyNode<T> newNode = new DoublyNode<T>(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
        Count++;
    }

    public bool Remove(T data)
    {
        DoublyNode<T>? current = head;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
            {
                if (current.Previous == null)
                {
                    head = current.Next;
                    if (head != null)
                        head.Previous = null;
                    else
                        tail = null;
                }
                else if (current.Next == null)
                {
                    tail = current.Previous;
                    tail.Next = null;
                }
                else
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                }
                Count--;
                return true;
            }
            current = current.Next;
        }
        return false;
    }
} 