namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System.Collections.Generic;
using System.Collections.ObjectModel;
public class Authenticator
{
    private static class EyeColors
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }
    public Authenticator(Identity admin)
    {
        this.Admin = admin;
    }

    public Identity Admin { get; }

    private readonly IReadOnlyDictionary<string, Identity> _developers
                    = new ReadOnlyDictionary<string, Identity>(new Dictionary<string, Identity>
                    {
                                    ["Bertrand"] = new Identity
                                    {
                                                    Email = "bert@ex.ism",
                                                    EyeColor = EyeColors.Blue
                                    },
                                    ["Anders"] = new Identity
                                    {
                                                    Email = "anders@ex.ism",
                                                    EyeColor = EyeColors.Brown
                                    }
                    });
    public IReadOnlyDictionary<string, Identity> GetDevelopers()
    {
        return _developers;
    }
}
public readonly struct Identity
{
    public string Email { get; init; }
    public string EyeColor { get; init; }
}        
