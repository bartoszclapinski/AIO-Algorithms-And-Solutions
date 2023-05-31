namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class SpaceAge
{
    private const double EarthOrbitInSeconds = 31557600;
    private const double MercuryOrbitInEarthYears = 0.2408467;
    private const double VenusOrbitInEarthYears = 0.61519726;
    private const double MarsOrbitInEarthYears = 1.8808158;
    private const double JupiterOrbitInEarthYears = 11.862615;
    private const double SaturnOrbitInEarthYears = 29.447498;
    private const double UranusOrbitInEarthYears = 84.016846;
    private const double NeptuneOrbitInEarthYears = 164.79132;

    private readonly double _ageInSeconds;
    
    public SpaceAge(int seconds)
    {
        this._ageInSeconds = seconds;
    }

    public double OnEarth()
    {
        return _ageInSeconds / EarthOrbitInSeconds;
    }

    public double OnMercury()
    {
        return OnEarth() / MercuryOrbitInEarthYears;
    }

    public double OnVenus()
    {
        return OnEarth() / VenusOrbitInEarthYears;
    }

    public double OnMars()
    {
        return OnEarth() / MarsOrbitInEarthYears;
    }

    public double OnJupiter()
    {
        return OnEarth() / JupiterOrbitInEarthYears;
    }

    public double OnSaturn()
    {
        return OnEarth() / SaturnOrbitInEarthYears;
    }

    public double OnUranus()
    {
        return OnEarth() / UranusOrbitInEarthYears;
    }

    public double OnNeptune()
    {
        return OnEarth() / NeptuneOrbitInEarthYears;
    }
}