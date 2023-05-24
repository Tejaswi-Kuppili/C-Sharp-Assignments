using System;
class SubString
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        s1 = s1.ToUpper();
        s2 = s2.ToUpper();
        Solution SubString = new Solution();
        if (SubString.FindSubString(s1, s2) == false)
        {
            Console.WriteLine("Sub String not found");
        }
        else
        {
            int occurances = SubString.PositionsOccurances(s1, s2);
            Console.WriteLine("\nNumber of Occurances: " + occurances);
            Console.ReadKey();
        }
    }
}
