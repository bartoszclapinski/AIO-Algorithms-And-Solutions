from typing import TypeVar, Generic, List
from collections import deque

T = TypeVar('T')

class Queue(Generic[T]):
    def __init__(self, capacity: int = 4):
        self._items: deque[T] = deque(maxlen=capacity)
        self._capacity = capacity

    def enqueue(self, item: T) -> None:
        if len(self._items) == self._capacity:
            self._resize()
        self._items.append(item)

    def dequeue(self) -> T:
        if self.is_empty():
            raise IndexError("Queue is empty")
        return self._items.popleft()

    def peek(self) -> T:
        if self.is_empty():
            raise IndexError("Queue is empty")
        return self._items[0]

    def _resize(self) -> None:
        self._capacity *= 2
        self._items = deque(self._items, maxlen=self._capacity)

    def clear(self) -> None:
        self._items.clear()

    def is_empty(self) -> bool:
        return len(self._items) == 0

    def size(self) -> int:
        return len(self._items) 