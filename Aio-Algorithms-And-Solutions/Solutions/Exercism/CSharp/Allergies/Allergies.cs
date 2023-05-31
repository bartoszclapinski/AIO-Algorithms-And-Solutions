namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.Allergies;

public class Allergies
{
    private readonly int _mask;

    public Allergies(int mask)
    {
        _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (_mask & (int)allergen) != 0;
    }

    public Allergen[] List()
    {
        var allergies = new List<Allergen>();
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
            {
                allergies.Add(allergen);
            }
        }
        return allergies.ToArray();
    }
}