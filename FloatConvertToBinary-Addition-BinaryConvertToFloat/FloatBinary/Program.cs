using System;
using System.Collections.Generic;
namespace FloatToBinaryConversion
{
    /// <summary>
    /// Class contains only main function to print the output and call neccessary methods to perform operations
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first float value");
            double input_number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second float value");
            double input_number2 = double.Parse(Console.ReadLine());
            FloatToBinaryConverter FTB = new FloatToBinaryConverter();
            string binary1 = FTB.FloatToBinary(input_number1);
            string binary2 = FTB.FloatToBinary(input_number2);
            Binary_addition add = new Binary_addition();
            double finalfloatresult = add.AddBinary(binary1, binary2);
            Console.WriteLine(finalfloatresult);
            Console.ReadKey();
        }
    }
}