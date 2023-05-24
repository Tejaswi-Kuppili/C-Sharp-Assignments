class Solution
{
    public int noOfOccurances = 0;
    public int index;
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
    public int PositionsOccurances(string str1, string str2)
    {
        Console.WriteLine("Index Positions:");

        while (index >= 0)
        {
            Console.WriteLine(index + " ");
            noOfOccurances++;
            index = str1.IndexOf(str2, index + 1);
        }
        return noOfOccurances;
    }
}
