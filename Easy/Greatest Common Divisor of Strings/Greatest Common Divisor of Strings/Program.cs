using System;
class Program
{
    static void Main(string[] args)
    {
        string str1 = "abcabc";
        string str2 = "abc";

        string result = GcdOfStrings(str1, str2);
        Console.WriteLine($"Greatest Common Divisor of Strings: {result} ");
    }

    static string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
            return "";

        int gcdLength = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);
    }

    static int Gcd(int a, int b)
    {
        while (b > 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
