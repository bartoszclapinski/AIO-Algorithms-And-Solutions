import java.util.Arrays;
import java.util.List;

public class GridChallenge {
    public static String gridChallenge(List<String> grid)
    {
        char[][] arr = new char[grid.size()][grid.size()];

        for (int i = 0; i < grid.size(); ++i)
        {
            arr[i] = grid.get(i).toCharArray();
            Arrays.sort(arr[i]);
        }

        for (int i = 0; i < arr[0].length; ++i)
        {
            for (int j = 0; j < arr.length - 1; ++j)
            {
                if (arr[j][i] > arr[j+1][i]) return "NO";
            }
        }
        return "YES";
    }
}