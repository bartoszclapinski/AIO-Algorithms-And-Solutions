from typing import TypeVar, Optional, Generic

T = TypeVar('T')

class Node(Generic[T]):
    def __init__(self, data: T):
        self.data: T = data
        self.next: Optional[Node[T]] = None

class LinkedList(Generic[T]):
    def __init__(self):
        self.head: Optional[Node[T]] = None
        self.tail: Optional[Node[T]] = None
        self.count: int = 0

    def add_first(self, data: T) -> None:
        new_node = Node(data)
        if self.head is None:
            self.head = self.tail = new_node
        else:
            new_node.next = self.head
            self.head = new_node
        self.count += 1

    def add_last(self, data: T) -> None:
        new_node = Node(data)
        if self.head is None:
            self.head = self.tail = new_node
        else:
            self.tail.next = new_node
            self.tail = new_node
        self.count += 1

    def remove(self, data: T) -> bool:
        current = self.head
        previous = None

        while current is not None:
            if current.data == data:
                if previous is None:
                    self.head = current.next
                    if self.head is None:
                        self.tail = None
                else:
                    previous.next = current.next
                    if current.next is None:
                        self.tail = previous
                self.count -= 1
                return True
            previous = current
            current = current.next
        return False

    def contains(self, data: T) -> bool:
        current = self.head
        while current is not None:
            if current.data == data:
                return True
            current = current.next
        return False

    def clear(self) -> None:
        self.head = None
        self.tail = None
        self.count = 0

    def reverse(self) -> None:
        previous = None
        current = self.head
        self.tail = self.head

        while current is not None:
            next_node = current.next
            current.next = previous
            previous = current
            current = next_node
        self.head = previous

    def find_middle(self) -> Optional[T]:
        if self.head is None:
            return None

        slow = fast = self.head
        while fast.next is not None and fast.next.next is not None:
            slow = slow.next
            fast = fast.next.next

        return slow.data

    def has_cycle(self) -> bool:
        if self.head is None:
            return False

        slow = fast = self.head
        while fast.next is not None and fast.next.next is not None:
            slow = slow.next
            fast = fast.next.next
            if slow == fast:
                return True
        return False

    @property
    def size(self) -> int:
        return self.count 