namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public static class ResistorColor
{
    public enum BandColor
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    }
    
    public static int ColorCode(string color)
    {
        Enum.TryParse(color, true, out BandColor result);
        return (int)result;
    }

    public static string[] Colors()
    {
        return Enum.GetNames(typeof(BandColor));
    }
}