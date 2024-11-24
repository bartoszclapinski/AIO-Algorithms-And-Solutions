import java.util.Objects;

class DoublyNode<T> {
    T data;
    DoublyNode<T> next;
    DoublyNode<T> previous;

    public DoublyNode(T data) {
        this.data = data;
        this.next = null;
        this.previous = null;
    }
}

public class DoublyLinkedList<T> {
    private DoublyNode<T> head;
    private DoublyNode<T> tail;
    private int count;

    public void addFirst(T data) {
        DoublyNode<T> newNode = new DoublyNode<>(data);
        if (head == null) {
            head = tail = newNode;
        } else {
            newNode.next = head;
            head.previous = newNode;
            head = newNode;
        }
        count++;
    }

    public void addLast(T data) {
        DoublyNode<T> newNode = new DoublyNode<>(data);
        if (head == null) {
            head = tail = newNode;
        } else {
            tail.next = newNode;
            newNode.previous = tail;
            tail = newNode;
        }
        count++;
    }

    public boolean remove(T data) {
        DoublyNode<T> current = head;
        while (current != null) {
            if (Objects.equals(current.data, data)) {
                if (current.previous == null) {
                    head = current.next;
                    if (head != null) {
                        head.previous = null;
                    } else {
                        tail = null;
                    }
                } else if (current.next == null) {
                    tail = current.previous;
                    tail.next = null;
                } else {
                    current.previous.next = current.next;
                    current.next.previous = current.previous;
                }
                count--;
                return true;
            }
            current = current.next;
        }
        return false;
    }
} 