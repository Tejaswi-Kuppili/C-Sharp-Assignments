using System;
class Program
{
    public static void Main(string[] args)
    {
        string num = Console.ReadLine();
        AdjacentDigitProduct product = new AdjacentDigitProduct();
        Console.WriteLine("Max Product: " + product.GreatestProduct(num));
        Console.ReadLine();
    }
}
