package exercism;

public class Wizard extends Fighter {
    private boolean preparedSpell = false;

    @Override
    boolean isVulnerable() {
        return !preparedSpell;
    }

    @Override
    int damagePoints(Fighter warrior) {
        return preparedSpell ? 12 : 3;
    }

    void prepareSpell() {
        preparedSpell = true;
    }

}
