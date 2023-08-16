namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var nums = phoneNumber.Split('-');
        return (nums[0] == "212",nums[1] == "555", nums[2]);
    }
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake == true;
    }
}