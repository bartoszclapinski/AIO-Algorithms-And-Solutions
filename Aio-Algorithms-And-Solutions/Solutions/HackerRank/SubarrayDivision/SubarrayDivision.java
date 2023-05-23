import java.util.List;

public class SubarrayDivision {
    public static int birthday(List<Integer> s, int d, int m){
        int result = 0, count = 0;

        for (int i = 0; i < s.size(); i++) {

            if ((i + m - 1) < s.size()) {

                for (int j = i; j < (i + m); j++) {

                    result += s.get(j);

                }

                if (result == d) count++;

                result = 0;
            }
        }
        return result;
    }
}