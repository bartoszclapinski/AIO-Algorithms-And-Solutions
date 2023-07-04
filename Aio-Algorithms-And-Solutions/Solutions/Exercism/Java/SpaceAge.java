package exercism;

public class SpaceAge {

    private static final double EARTH_YEAR_IN_SECONDS = 31557600;
    private static final double MERCURY_ORBITAL_PERIOD = EARTH_YEAR_IN_SECONDS * 0.2408467;
    private static final double VENUS_ORBITAL_PERIOD = EARTH_YEAR_IN_SECONDS * 0.61519726;
    private static final double MARS_ORBITAL_PERIOD = EARTH_YEAR_IN_SECONDS * 1.8808158;
    private static final double JUPITER_ORBITAL_PERIOD = EARTH_YEAR_IN_SECONDS * 11.862615;
    private static final double SATURN_ORBITAL_PERIOD = EARTH_YEAR_IN_SECONDS * 29.447498;
    private static final double URANUS_ORBITAL_PERIOD = EARTH_YEAR_IN_SECONDS * 84.016846;
    private static final double NEPTUNE_ORBITAL_PERIOD = EARTH_YEAR_IN_SECONDS * 164.79132;

    private final double seconds;

    public SpaceAge(double seconds) {
        this.seconds = seconds;
    }

    public double getSeconds() {
        return seconds;
    }

    public double onEarth() {
        return seconds / EARTH_YEAR_IN_SECONDS;
    }

    public double onMercury() {
        return seconds / MERCURY_ORBITAL_PERIOD;
    }

    public double onVenus() {
        return seconds / VENUS_ORBITAL_PERIOD;
    }

    public double onMars() {
        return seconds / MARS_ORBITAL_PERIOD;
    }

    public double onJupiter() {
        return seconds / JUPITER_ORBITAL_PERIOD;
    }

    public double onSaturn() {
        return seconds / SATURN_ORBITAL_PERIOD;
    }

    public double onUranus() {
        return seconds / URANUS_ORBITAL_PERIOD;
    }

    public double onNeptune() {
        return seconds / NEPTUNE_ORBITAL_PERIOD;
    }
}






