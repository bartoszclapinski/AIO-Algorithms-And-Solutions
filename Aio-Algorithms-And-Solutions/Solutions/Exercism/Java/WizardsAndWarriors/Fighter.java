package exercism;

public abstract class Fighter {
    abstract boolean isVulnerable();
    abstract int damagePoints(Fighter fighter);

    @Override
    public String toString() {
        return "Fighter is a " + getClass().getSimpleName();
    }
}


