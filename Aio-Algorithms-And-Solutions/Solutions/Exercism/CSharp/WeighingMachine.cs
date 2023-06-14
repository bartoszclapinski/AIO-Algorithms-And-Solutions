using Microsoft.VisualBasic.CompilerServices;

namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class WeighingMachine
{
    public int Precision { get; }

    private double _weight;
    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0) 
                throw new ArgumentOutOfRangeException(nameof(value), "Weight cannot be negative");
            _weight = value;
        }
    }

    public double TareAdjustment { get; set; }

    public string DisplayWeight
    {
        get
        {
            var displayWeight = Weight - TareAdjustment;
            return $"{displayWeight.ToString($"F{Precision}")} kg";
        }
    }

    public WeighingMachine(int precision)
    {
        Precision = precision;
        TareAdjustment = 5.0;
    }
}