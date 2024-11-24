public class ArrayOperations
{
    // Basic Operations
    public static void Insert<T>(ref T[] array, T element, int position)
    {
        if (position < 0 || position > array.Length)
            throw new ArgumentOutOfRangeException("position");

        T[] newArray = new T[array.Length + 1];
        
        // Copy elements before position
        Array.Copy(array, 0, newArray, 0, position);
        
        // Insert new element
        newArray[position] = element;
        
        // Copy elements after position
        Array.Copy(array, position, newArray, position + 1, array.Length - position);
        
        array = newArray;
    }

    public static void Delete<T>(ref T[] array, int position)
    {
        if (position < 0 || position >= array.Length)
            throw new ArgumentOutOfRangeException("position");

        T[] newArray = new T[array.Length - 1];
        
        // Copy elements before position
        Array.Copy(array, 0, newArray, 0, position);
        
        // Copy elements after position
        Array.Copy(array, position + 1, newArray, position, array.Length - position - 1);
        
        array = newArray;
    }

    public static int Search<T>(T[] array, T element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]?.Equals(element) == true)
                return i;
        }
        return -1;
    }

    public static void Update<T>(T[] array, T element, int position)
    {
        if (position < 0 || position >= array.Length)
            throw new ArgumentOutOfRangeException("position");

        array[position] = element;
    }

    public static void Reverse<T>(T[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array.Length == 0)
            throw new ArgumentException("Array is empty");

        T max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
                max = array[i];
        }
        return max;
    }

    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        if (array.Length == 0)
            throw new ArgumentException("Array is empty");

        T min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(min) < 0)
                min = array[i];
        }
        return min;
    }

    // Common Array Algorithms
    public static void Rotate<T>(T[] array, int positions)
    {
        int n = array.Length;
        positions = positions % n;
        
        // Create temporary array to store rotated elements
        T[] temp = new T[positions];
        
        // Store first 'positions' elements in temp array
        Array.Copy(array, 0, temp, 0, positions);
        
        // Shift remaining elements to the left
        Array.Copy(array, positions, array, 0, n - positions);
        
        // Copy temp elements to end
        Array.Copy(temp, 0, array, n - positions, positions);
    }

    public static List<T> FindDuplicates<T>(T[] array)
    {
        List<T> duplicates = new List<T>();
        HashSet<T> seen = new HashSet<T>();

        foreach (T item in array)
        {
            if (!seen.Add(item) && !duplicates.Contains(item))
                duplicates.Add(item);
        }

        return duplicates;
    }
}
