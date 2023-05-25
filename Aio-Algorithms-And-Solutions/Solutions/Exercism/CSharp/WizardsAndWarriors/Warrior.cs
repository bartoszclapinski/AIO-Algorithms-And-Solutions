namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.WizardsAndWarriors;

public class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }    
}