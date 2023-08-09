namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System; 
public struct CurrencyAmount
{
    private decimal _amount;
    private string _currency;
    public CurrencyAmount(decimal amount, string currency)
    {
        this._amount = amount;
        this._currency = currency;
    }
    // equality operators
    public static bool operator == (CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount == b._amount);
    public static bool operator != (CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount != b._amount);
    // comparison operators
    public static bool operator >(CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount > b._amount);
    
    public static bool operator <(CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount < b._amount);
    
    public static bool operator >=(CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount >= b._amount);
    
    public static bool operator <=(CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount <= b._amount);
    
    // arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount a) => a;
    
    public static CurrencyAmount operator -(CurrencyAmount a) => new CurrencyAmount(-a._amount, a._currency);
    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount + b._amount);
    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount - b._amount);
    public static CurrencyAmount operator *(CurrencyAmount a, CurrencyAmount b) =>
        ValidateOperator(a, b, a._amount * b._amount);
    public static CurrencyAmount operator /(CurrencyAmount a, CurrencyAmount b) =>
        (b._amount == 0)
        ? throw new DivideByZeroException()
        : ValidateOperator(a, b, a._amount / b._amount);
    // type conversion operators
    public static implicit operator double(CurrencyAmount c) => (double)c._amount;
    
    public static implicit operator decimal(CurrencyAmount c) => c._amount;
    
    // private helper methods 
    private static CurrencyAmount ValidateOperator(CurrencyAmount a, CurrencyAmount b, decimal newAmount) => 
        ( SameCurrency(a, b) ) 
        ? new CurrencyAmount(newAmount, a._currency)
        : throw new ArgumentException();
    
    private static bool ValidateOperator(CurrencyAmount a, CurrencyAmount b, bool result) => 
        ( SameCurrency(a, b) ) ? result : throw new ArgumentException();
    
    private static bool SameCurrency(CurrencyAmount a, CurrencyAmount b) => 
        (a._currency == b._currency) ? true : throw new ArgumentException();
}