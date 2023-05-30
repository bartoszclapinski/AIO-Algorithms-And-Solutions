namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.FootballMatchReport;

public class Injury : Incident
{
    private readonly int _player;

    public Injury(int player)
    {
        _player = player;
    }

    public override string GetDescription() => $"Player {_player} is injured.";
}