

public static class Panagram
{
    public static bool IsPanagram(string input)
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string lowerInput = input.ToLower();

        return alphabet.All(letter => lowerInput.Contains(letter));
    }
}