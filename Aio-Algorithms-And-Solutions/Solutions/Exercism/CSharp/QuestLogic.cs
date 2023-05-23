namespace Aio_Algorithms_And_Solutions.Solutions.Exercism;

public class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake) return false;
        else return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake || prisonerIsAwake) return true;
        else return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake) return true;
        else return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent && !archerIsAwake) return true;
        else if (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake) return true;
        else return false;
    }    
}