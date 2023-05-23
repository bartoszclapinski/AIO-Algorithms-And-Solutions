public class CaesarCipher {
    public static String caesarCipher(String s, int k)
    {
        StringBuilder result = new StringBuilder();
        char c;
        if (k > 26) k = k % 26;

        for (int i = 0; i < s.length(); i++)
        {
            c = s.charAt(i);
            if (!Character.isAlphabetic(c))
                result.append(c);
            else if (Character.toLowerCase(c) + k > 'z')
                result.append((char) (c + k - 26));
            else
                result.append((char) (c + k));
        }
        return result.toString();
    }
}
