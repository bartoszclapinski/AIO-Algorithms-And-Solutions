import java.util.Collections;
import java.util.List;

public class MaxMin {
    public static int MaxMin(int k, List<Integer> arr) {
        int result = Integer.MAX_VALUE;
        Collections.sort(arr);

        for (int i = 0; i <= arr.size() - k; ++i)
        {
            result =    Math.min(result,
                    Math.max(arr.get(i), arr.get(i + k - 1)) -
                            Math.min(arr.get(i), arr.get(i + k - 1)));
        }
        return result;
    }
}