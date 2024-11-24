from typing import TypeVar, Optional, Generic

T = TypeVar('T')

class DoublyNode(Generic[T]):
    def __init__(self, data: T):
        self.data: T = data
        self.next: Optional[DoublyNode[T]] = None
        self.previous: Optional[DoublyNode[T]] = None

class DoublyLinkedList(Generic[T]):
    def __init__(self):
        self.head: Optional[DoublyNode[T]] = None
        self.tail: Optional[DoublyNode[T]] = None
        self.count: int = 0

    def add_first(self, data: T) -> None:
        new_node = DoublyNode(data)
        if self.head is None:
            self.head = self.tail = new_node
        else:
            new_node.next = self.head
            self.head.previous = new_node
            self.head = new_node
        self.count += 1

    def add_last(self, data: T) -> None:
        new_node = DoublyNode(data)
        if self.head is None:
            self.head = self.tail = new_node
        else:
            self.tail.next = new_node
            new_node.previous = self.tail
            self.tail = new_node
        self.count += 1

    def remove(self, data: T) -> bool:
        current = self.head
        while current is not None:
            if current.data == data:
                if current.previous is None:
                    self.head = current.next
                    if self.head is not None:
                        self.head.previous = None
                    else:
                        self.tail = None
                elif current.next is None:
                    self.tail = current.previous
                    self.tail.next = None
                else:
                    current.previous.next = current.next
                    current.next.previous = current.previous
                self.count -= 1
                return True
            current = current.next
        return False 