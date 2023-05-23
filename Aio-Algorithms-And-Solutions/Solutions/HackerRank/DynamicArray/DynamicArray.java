import java.util.ArrayList;
import java.util.List;

public class DynamicArray {
    public static List<Integer> dynamicArray(int n, List<List<Integer>> queries)
    {
        List<List<Integer>> arr = new ArrayList<>();
        for (int i = 0; i < n; ++i) arr.add(new ArrayList<>());

        List<Integer> result = new ArrayList<>();
        int last = 0;

        for (int i = 0; i < queries.size(); ++i)
        {
            int x = queries.get(i).get(1);
            int y = queries.get(i).get(2);
            int index = (x ^ last) % n;

            if (queries.get(i).get(0) == 1)
            {
                arr.get(index).add(y);
            }
            else if (queries.get(i).get(0) == 2)
            {
                last = arr.get(index).get(y % arr.get(index).size());
                result.add(last);
            }
        }
        return result;
    }

}