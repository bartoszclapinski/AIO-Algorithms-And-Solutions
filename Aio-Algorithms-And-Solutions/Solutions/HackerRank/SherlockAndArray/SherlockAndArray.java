import java.util.List;

public class SherlockAndArray {
    public static String balancedSums(List<Integer> arr)
    {
        int size = arr.size();

        if (size == 1) return "YES";
        if (size == 2) return "NO";

        int sum = 0;
        for (int i : arr) sum += i;

        int left = 0;
        int right = sum - arr.get(0);
        if (left == right) return "YES";

        for (int i = 1; i < size - 1; ++i)
        {
            left += arr.get(i - 1);
            right -= arr.get(i);
            if (left == right) return "YES";
        }

        left = sum - arr.get(size - 1);
        right = 0;
        if (left == right) return "YES";

        return "NO";
    }
}