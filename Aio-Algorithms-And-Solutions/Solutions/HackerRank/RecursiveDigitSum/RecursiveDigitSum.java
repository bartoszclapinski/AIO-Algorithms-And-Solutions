package HackerRank.RecursiveDigitSum;

public class RecursiveDigitSum {
    public static int superDigit(String n, int k)
    {
        long sum = 0;

        for (int i = 0; i < n.length(); ++i)
            sum += Integer.parseInt(String.valueOf(n.charAt(i)));

        sum *= k;

        if (sum > 9)
            return superDigit(String.valueOf(sum), 1);
        else
            return (int)sum;

    }
}