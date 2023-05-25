namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.WizardsAndWarriors;

public class Wizard : Character
{
    private int _damage;

    public Wizard() : base("Wizard")
    {
        _damage = 3;
    }

    public override int DamagePoints(Character target)
    {
        return _damage;
    }

    public override bool Vulnerable()
    {
        return _damage == 3;
    }

    public void PrepareSpell()
    {
        _damage = 12;
    }    
}