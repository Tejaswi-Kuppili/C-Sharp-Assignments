using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 class SubString
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        Console.WriteLine(s1.ToUpper());
        Console.WriteLine(s2.ToUpper());
        int occured = 0;
        int index = s1.IndexOf(s2);
        Console.WriteLine("INDEX POSITIONS");
        while (index >= 0)
        {
            Console.WriteLine(index + " ");
            occured++;
            index = s1.IndexOf(s2, index + 1);
        }
        Console.WriteLine("\nNUMBER OF OCCURANCES: " + occured);
        Console.ReadKey();
    }
}