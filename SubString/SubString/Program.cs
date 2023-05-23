using System;
class SubString
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        s1 = s1.ToUpper();
        s2 = s2.ToUpper();
        int occurance = 0;
        int index = s1.IndexOf(s2);
        Console.WriteLine("INDEX POSITIONS");
        while (index >= 0)
        {
            Console.WriteLine(index + " ");
            occurances++;
            index = s1.IndexOf(s2, index + 1);
        }
        Console.WriteLine("\nNUMBER OF OCCURANCES: " + occured);
        Console.ReadKey();
    }
}
