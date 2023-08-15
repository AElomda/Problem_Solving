using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] candies = { 2, 3, 5, 1, 3 };
        int extraCandies = 3;

        IList<bool> result = KidsWithCandies(candies, extraCandies);

        Console.WriteLine("Result:");
        foreach (bool canHaveGreatestCandies in result)
        {
            Console.WriteLine(canHaveGreatestCandies);
        }
    }

    static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxCandies = 0;

        foreach (int candyCount in candies)
        {
            maxCandies = Math.Max(maxCandies, candyCount);
        }

        IList<bool> result = new List<bool>();

        foreach (int candyCount in candies)
        {
            result.Add(candyCount + extraCandies >= maxCandies);
        }

        return result;
    }
}
