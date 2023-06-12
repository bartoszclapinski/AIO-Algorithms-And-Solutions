using System.Dynamic;

namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            checked
            {
                return Convert.ToString(@base * multiplier);
            }
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }    
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        float result = @base * multiplier;
        if (float.IsInfinity(result)) return "*** Too Big ***";
        
        return Convert.ToString(result);
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            checked
            {
                return Convert.ToString(salaryBase * multiplier);
            }
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}
