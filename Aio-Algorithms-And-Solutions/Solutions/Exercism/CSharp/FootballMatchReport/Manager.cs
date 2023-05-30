namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.FootballMatchReport;

public class Manager
{
    public string Name { get; }

    public string? Club { get; }

    public Manager(string name, string? club)
    {
        Name = name;
        Club = club;
    }
}