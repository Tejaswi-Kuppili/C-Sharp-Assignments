using System;
class Solution
{
    public int noOfOccurances = 0;
    public int index;
    /// <summary>
    /// Finding whether the sub string is present or not and index positions of the substring
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool FindSubString(string s1, string s2)
    {
        int index = s1.IndexOf(s2);
        if (index == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    /// <summary>
    /// Finding the number of occurances of that particular sub string found
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public int PositionsOccurances(string str1, string str2)
    {
        Console.WriteLine("Index Positions:");
        index = str1.IndexOf(str2);
        while (index >= 0)
        {
            Console.Write(index + " ");
            noOfOccurances++;
            index = str1.IndexOf(str2, index + 1);
        }
        return noOfOccurances;
    }
}
