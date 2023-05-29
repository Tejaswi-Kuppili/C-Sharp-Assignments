using System;
class SubString
{
    public static void Main(string[] args)
    {
        string string1 = Console.ReadLine();
        string string2 = Console.ReadLine();
        string1 = string1.ToUpper();
        string2 = string2.ToUpper();
        Validation validstring = new Validation();
        Solution SubString = new Solution();
        int checkValidation = validstring.ValidationEdgeCases(string1, string2);
        //Validation Check for edge cases
        if (checkValidation == 0)
        {
            Console.WriteLine("Both the strings are given empty !\nEnter valid Strings !");
            Console.ReadKey();
        }
        else if (checkValidation == 1)
        {
            Console.WriteLine("String 1 is Empty !\nEnter valid String 1 !");
            Console.ReadKey();
        }
        else if (checkValidation == 2)
        {
            Console.WriteLine("String 2 is Empty !\nEnter valid String 2 !");
            Console.ReadKey();
        }
        else if (checkValidation == 3)
        {
            Console.WriteLine("Length of String 2 should be smaller than Length of String 1 !");
            Console.ReadKey();
        }
        else if (SubString.FindSubString(string1, string2) == false)
        {
            Console.WriteLine("Sub String not found");
            Console.ReadKey();
        }
        else
        {
            int occurances = SubString.PositionsOccurances(string1, string2);
            Console.WriteLine("\nNumber of Occurances: " + occurances);
            Console.ReadKey();
        }
    }
}