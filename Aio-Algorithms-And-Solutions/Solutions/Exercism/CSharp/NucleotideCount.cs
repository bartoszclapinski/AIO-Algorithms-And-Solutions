namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var nucleotides = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        
        foreach (var nucleotide in sequence)
        {
            if (!nucleotides.ContainsKey(nucleotide))
            {
                throw new ArgumentException();
            }
            
            nucleotides[nucleotide]++;
        }

        return nucleotides;
    }
}