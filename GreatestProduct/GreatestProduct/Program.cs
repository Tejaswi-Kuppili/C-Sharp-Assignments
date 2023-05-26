using System;
class Program
{
    public static void Main(string[] args)
    {
        string num = Console.ReadLine();
        Validation validstring = new Validation();
        AdjacentDigitProduct product = new AdjacentDigitProduct();
        int checkValidation = validstring.ValidationEdgeCases(num);
        if (checkValidation == 1) 
        {
            Console.WriteLine("Enter a string consisting of numbers with a length of atleast 4 digits");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Max Product: " + product.GreatestProduct(num));
            Console.ReadKey();
        }
    }
}
