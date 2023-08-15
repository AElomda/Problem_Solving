using System;
namespace Merging
{
    class Program
    {
        #region 1768. Merge Strings Alternately
        //You are given two strings word1 and word2. Merge the strings by adding letters in alternating order,
        //starting with word1. If a string is longer than the other,
        //append the additional letters onto the end of the merged string.
        //Return the merged string. 
        #endregion

        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string word1 = "abc";
            string word2 = "pqr";
            string merged = solution.MergeAlternately(word1, word2);

            Console.WriteLine("Merged String: " + merged);
        }
    } 
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            string result = "";
            int MaxLength = Math.Max(word1.Length, word2.Length);
            for (int i = 0; i < MaxLength; i++)
            {
                if(i < word1.Length)
                {
                    result += word1[i];
                }
                if (i < word2.Length)
                {
                    result += word2[i];
                }
            }
            return result;
        }
    }
}



