public class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T>? head;
    private Node<T>? tail;
    public int Count { get; private set; }

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
        Count++;
    }

    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            tail = newNode;
        }
        Count++;
    }

    public bool Remove(T data)
    {
        Node<T>? current = head;
        Node<T>? previous = null;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
            {
                if (previous == null)
                {
                    head = current.Next;
                    if (head == null)
                        tail = null;
                }
                else
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                        tail = previous;
                }
                Count--;
                return true;
            }
            previous = current;
            current = current.Next;
        }
        return false;
    }

    public bool Contains(T data)
    {
        Node<T>? current = head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
                return true;
            current = current.Next;
        }
        return false;
    }

    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public void Reverse()
    {
        Node<T>? previous = null;
        Node<T>? current = head;
        tail = head;

        while (current != null)
        {
            Node<T>? next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }
        head = previous;
    }

    public T? FindMiddle()
    {
        if (head == null)
            return default;

        Node<T>? slow = head;
        Node<T>? fast = head;

        while (fast?.Next != null)
        {
            slow = slow!.Next;
            fast = fast.Next.Next;
        }

        return slow!.Data;
    }

    public bool HasCycle()
    {
        if (head == null)
            return false;

        Node<T>? slow = head;
        Node<T>? fast = head;

        while (fast?.Next != null)
        {
            slow = slow!.Next;
            fast = fast.Next.Next;
            if (slow == fast)
                return true;
        }

        return false;
    }
} 