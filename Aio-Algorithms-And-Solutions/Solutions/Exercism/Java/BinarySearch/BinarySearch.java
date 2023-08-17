package exercism;

import java.util.stream.Collectors;
import java.util.*;

import java.util.List;
public class BinarySearch {
    private final List<Integer> list;
    public BinarySearch(List<Integer> list) {
        this.list = list;
    }
    public int indexOf(int target) throws ValueNotFoundException {
        int leftPointer = 0;
        int rightPointer = list.size() - 1;
        while(leftPointer <= rightPointer) {
            int middlePointer = ((rightPointer - leftPointer) / 2) + leftPointer;
            int numInMiddle = list.get(middlePointer);
            if (numInMiddle == target)
                return middlePointer;
            else if (target > numInMiddle)
                leftPointer = middlePointer + 1;
            else
                rightPointer = middlePointer - 1;
        }
        throw new ValueNotFoundException("Value not in array");
    }
}