namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System.Linq;
public static class Bob
{
    public static string Response(string message)
    {
        return message.IsSilence() ? "Fine. Be that way!" :
                        message.IsYell() && message.IsQuestion() ? "Calm down, I know what I'm doing!" :
                        message.IsYell() ? "Whoa, chill out!" :
                        message.IsQuestion() ? "Sure." : "Whatever.";
    }
    private static bool IsSilence(this string message) => string.IsNullOrWhiteSpace(message);
    private static bool IsYell(this string message) => message.Any(char.IsLetter) && message.ToUpperInvariant() == message;
    private static bool IsQuestion(this string message) => message.TrimEnd().EndsWith("?"); 
}