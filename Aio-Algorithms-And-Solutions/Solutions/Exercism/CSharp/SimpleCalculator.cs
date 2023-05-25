namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        return operation switch
        {
            null => throw new ArgumentNullException(),
            "" => throw new ArgumentException(),
            _ => operation switch
            {
                "+" => $"{operand1} {operation} {operand2} = {(operand1 + operand2).ToString()}",
                "*" => $"{operand1} {operation} {operand2} = {(operand1 * operand2).ToString()}",
                "/" => operand2 == 0
                    ? "Division by zero is not allowed."
                    : $"{operand1} {operation} {operand2} = {(operand1 / operand2).ToString()}",
                _ => throw new ArgumentOutOfRangeException()
            }
        };
    }    
}