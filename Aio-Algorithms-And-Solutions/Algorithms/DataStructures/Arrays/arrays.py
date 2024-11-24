from typing import TypeVar, List, Set, Any, Optional
from collections import deque

T = TypeVar('T')

class ArrayOperations:
    @staticmethod
    def insert(array: List[T], element: T, position: int) -> List[T]:
        if position < 0 or position > len(array):
            raise ValueError("Invalid position")
        return array[:position] + [element] + array[position:]

    @staticmethod
    def delete(array: List[T], position: int) -> List[T]:
        if position < 0 or position >= len(array):
            raise ValueError("Invalid position")
        return array[:position] + array[position + 1:]

    @staticmethod
    def search(array: List[T], element: T) -> int:
        try:
            return array.index(element)
        except ValueError:
            return -1

    @staticmethod
    def update(array: List[T], element: T, position: int) -> None:
        if position < 0 or position >= len(array):
            raise ValueError("Invalid position")
        array[position] = element

    @staticmethod
    def reverse(array: List[T]) -> None:
        left, right = 0, len(array) - 1
        while left < right:
            array[left], array[right] = array[right], array[left]
            left += 1
            right -= 1

    @staticmethod
    def find_max(array: List[Any]) -> Optional[Any]:
        if not array:
            raise ValueError("Array is empty")
        return max(array)

    @staticmethod
    def find_min(array: List[Any]) -> Optional[Any]:
        if not array:
            raise ValueError("Array is empty")
        return min(array)

    @staticmethod
    def rotate(array: List[T], positions: int) -> None:
        if not array:
            return
        positions = positions % len(array)
        deque(array).rotate(-positions)

    @staticmethod
    def find_duplicates(array: List[T]) -> List[T]:
        seen: Set[T] = set()
        duplicates: Set[T] = set()
        for item in array:
            if item in seen:
                duplicates.add(item)
            seen.add(item)
        return list(duplicates) 