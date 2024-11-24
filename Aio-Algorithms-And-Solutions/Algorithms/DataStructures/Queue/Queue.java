import java.util.NoSuchElementException;

public class Queue<T> {
    private T[] items;
    private int head;
    private int tail;
    private int count;
    private static final int DEFAULT_CAPACITY = 4;

    @SuppressWarnings("unchecked")
    public Queue(int capacity) {
        items = (T[]) new Object[capacity];
        head = 0;
        tail = 0;
        count = 0;
    }

    public Queue() {
        this(DEFAULT_CAPACITY);
    }

    public void enqueue(T item) {
        if (count == items.length) {
            resize();
        }
        items[tail] = item;
        tail = (tail + 1) % items.length;
        count++;
    }

    public T dequeue() {
        if (isEmpty()) {
            throw new NoSuchElementException("Queue is empty");
        }
        T item = items[head];
        items[head] = null;
        head = (head + 1) % items.length;
        count--;
        return item;
    }

    public T peek() {
        if (isEmpty()) {
            throw new NoSuchElementException("Queue is empty");
        }
        return items[head];
    }

    @SuppressWarnings("unchecked")
    private void resize() {
        T[] newItems = (T[]) new Object[items.length * 2];
        if (head < tail) {
            System.arraycopy(items, head, newItems, 0, count);
        } else {
            System.arraycopy(items, head, newItems, 0, items.length - head);
            System.arraycopy(items, 0, newItems, items.length - head, tail);
        }
        items = newItems;
        head = 0;
        tail = count;
    }

    public void clear() {
        for (int i = 0; i < items.length; i++) {
            items[i] = null;
        }
        head = 0;
        tail = 0;
        count = 0;
    }

    public boolean isEmpty() {
        return count == 0;
    }

    public int size() {
        return count;
    }
} 