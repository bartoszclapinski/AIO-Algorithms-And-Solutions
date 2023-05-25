namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        return id == null ? 
            $"{name} - {department?.ToUpper() ?? "OWNER"}" : $"[{id}] - {name} - {department?.ToUpper() ?? "OWNER"}";
    }    
}