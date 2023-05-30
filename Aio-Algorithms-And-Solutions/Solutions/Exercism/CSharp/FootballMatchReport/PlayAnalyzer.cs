namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.FootballMatchReport;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 => "center back",
            4 => "center back",
            5 => "right back",
            6 => "midfielder",
            7 => "midfielder",
            8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public static string AnalyzeOffField(object report)
    {
        return report switch
        {
            int n => $"There are {n} supporters at the match.",
            string s => s,
            Injury i => "Oh no! " + i.GetDescription() + " Medics are on the field.",
            Incident inc => inc.GetDescription(),
            Manager manager => manager.Club is null ? manager.Name : $"{manager.Name} ({manager.Club})",
            _ => throw new ArgumentException()
        };
    }
}