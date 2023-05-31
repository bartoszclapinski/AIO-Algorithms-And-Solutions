using System.Text;

namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var cipher = new StringBuilder(text.Length);
        foreach (var character in text)
        {
            if (char.IsLetter(character))
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                cipher.Append((char) ((character + shiftKey - offset) % 26 + offset));
            }
            else
            {
                cipher.Append(character);
            }
        }

        return cipher.ToString();    
    }
}