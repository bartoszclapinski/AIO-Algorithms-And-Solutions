using System.Text;

namespace Aio_Algorithms_And_Solutions.Solutions.Exercism;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        
        // Iterate over each character in the string
        for (int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];
            
            // Replace spaces with underscores
            if (c == ' ') {
                sb.Append('_');
            }
            // Replace control characters with "CTRL"
            else if (char.IsControl(c)) {
                sb.Append("CTRL");
            }
            // Convert kebab-case to camelCase
            else if (c == '-' && i < identifier.Length - 1) {
                sb.Append(char.ToUpper(identifier[i+1]));
                i++; // skip next character
            }
            // Omit any characters that are not letters
            else if (char.IsLetter(c) && (c < 'α' || c > 'ω')) {
                sb.Append(c);
            }
        }
        
        return sb.ToString();
    }
}