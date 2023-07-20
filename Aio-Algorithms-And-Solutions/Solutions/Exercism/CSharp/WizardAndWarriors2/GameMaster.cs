namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.WizardAndWarriors2;

static class GameMaster
{
    public static string Describe(Character character)
    {
        return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
    }

    public static string Describe(Destination destination)
    {
        return $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }

    public static string Describe(TravelMethod travelMethod)
    {
        return travelMethod switch
        {
                        TravelMethod.Walking => "You're traveling to your destination by walking.",
                        TravelMethod.Horseback => "You're traveling to your destination on horseback.",
                        _ => throw new ArgumentOutOfRangeException(nameof(travelMethod), travelMethod, null)
        };
    }

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
    {
        return $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}";
    }

    public static string Describe(Character character, Destination destination)
    {
        return Describe(character, destination, TravelMethod.Walking);
    }
}