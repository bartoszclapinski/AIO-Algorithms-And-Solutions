namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.WizardsAndWarriors;

public abstract class Character
{
    private string _characterType;
    
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {GetType().Name}";
    }    
}