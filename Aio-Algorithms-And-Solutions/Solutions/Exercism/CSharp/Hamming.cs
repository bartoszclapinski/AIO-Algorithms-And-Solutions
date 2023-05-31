using System.Linq;

namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();

        return firstStrand.Where((t, i) => t != secondStrand[i]).Count();
    }
}