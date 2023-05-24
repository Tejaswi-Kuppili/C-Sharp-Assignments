class Solution
{
    public int noOfOccurances = 0;
    public int index;
    //Method to find substring is present or not
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
    //Method to find Index Positions and Number of Occurances
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
