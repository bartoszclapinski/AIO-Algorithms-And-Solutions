namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class Robot
{
    private static readonly HashSet<string> Names = new ();
    private static readonly Random Random = new ();
    private string Name { get; set; }
    
    public Robot()
    {
        Reset();
    }

    public void Reset()
    {
        string newName;

        do
        {
            newName = GenerateName();
        }
        while (!Names.Add(newName));

        Names.Remove(Name);

        Name = newName;
    }

    private static string GenerateName()
    {
        var letterPart = (char)('A' + Random.Next(0, 26));
        var secondLetterPart = (char)('A' + Random.Next(0, 26));
        var numberPart = Random.Next(0, 1000); 
        return $"{letterPart}{secondLetterPart}{numberPart:D3}";
    }
}