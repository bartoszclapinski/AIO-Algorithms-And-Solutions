namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;
using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private readonly Queue<T> _buffer;
    private readonly int _capacity;

    public CircularBuffer(int capacity)
    {
        if (capacity < 1)
        {
            throw new ArgumentException("Capacity must be positive.", nameof(capacity));
        }
        
        _buffer = new Queue<T>(capacity);
        _capacity = capacity;
    }

    public T Read()
    {
        if (_buffer.Count == 0)
        {
            throw new InvalidOperationException("Cannot read from an empty buffer.");
        }
        
        return _buffer.Dequeue();
    }

    public void Write(T value)
    {
        if (_buffer.Count == _capacity)
        {
            throw new InvalidOperationException("Cannot write to a full buffer.");
        }
        
        _buffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (_buffer.Count == _capacity)
        {
            _buffer.Dequeue();
        }
        
        _buffer.Enqueue(value);
    }

    public void Clear()
    {
        _buffer.Clear();
    }
}
