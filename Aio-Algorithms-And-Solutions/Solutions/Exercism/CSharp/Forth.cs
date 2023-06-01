namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Collections.Generic;
using System.Linq;


public static class Forth
{
    private static Dictionary<string, string[]> defines;
    
    public static string Evaluate(string[] instructions)
    {
        defines = new Dictionary<string, string[]>();
        if (!instructions.Any()) return string.Empty;
        
        var stackString = new Stack<string>(string.Join(" ", instructions).ToUpper().Split(" ").Reverse());
        var stackInt = new Stack<int>();
        
        while (stackString.Any())
        {
            switch(stackString.Pop())
            {
                 case var st when int.TryParse(st, out int number):
                    stackInt.Push(number);
                    break;
                    
                case var st when defines.ContainsKey(st):
                    foreach (var define in defines[st].Reverse()) 
                        stackString.Push(define);
                    break;
                case "+": 
                    stackInt.Push(Add(stackInt.Pop(), stackInt.Pop())); 
                    break;
                case "-": 
                    stackInt.Push(Sub(stackInt.Pop(), stackInt.Pop())); 
                    break;
                case "*": 
                    stackInt.Push(Mul(stackInt.Pop(),stackInt.Pop())); 
                    break;
                case "/":                    
                    stackInt.Push(Div(stackInt.Pop(), stackInt.Pop()));
                    break;
                case "DUP": 
                    stackInt.Push(stackInt.Peek()); 
                    break;
                case "DROP": 
                    stackInt.Pop(); 
                    break;
                case "SWAP":
                    foreach (var item in new[] { stackInt.Pop(), stackInt.Pop() }) 
                        stackInt.Push(item);
                    break;
                case "OVER":
                    foreach (var item in new[] { stackInt.Pop(), stackInt.Peek() })
                        stackInt.Push(item);
                    break;
                case ":":
                     Define(ref stackString);
                    break;
                    
                default: 
                    throw new InvalidOperationException();
            }
        }
        return string.Join(" ", stackInt.Reverse());
    }
    private static int Add(int x, int y) 
        => y + x;
    private static int Sub(int x, int y) 
        => y - x;
    private static int Mul(int x, int y)
        => y * x;
    private static int Div(int x, int y) 
        => x == 0 ? 
            throw new DivideByZeroException()
            : y / x;
    
    private static void Define(ref Stack<string> input)
    {
        var key = input.Pop();
        if (int.TryParse(key, out int num))
            throw new InvalidOperationException();
        var values = new List<string>();
        var value = input.Pop();
        while (!value.Equals(";"))
        {
            values.Add(value);
            value = input.Pop();
        }
        defines[key] = values.SelectMany(k => defines.ContainsKey(k) ? defines[k] : new[] { k }).ToArray();
    }
}