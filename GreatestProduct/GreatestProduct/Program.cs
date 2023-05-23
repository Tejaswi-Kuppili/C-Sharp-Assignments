using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    public static void Main(string[] args)
    {
        string num = Console.ReadLine();
        int adjDigits = 4;
        long maxProduct = 0;

        for (int i = 0; i <= num.Length - adjDigits; i++)
        {
            long product = 1;
            for (int j = 0; j < adjDigits; j++)
            {
                int digit = Convert.ToInt32(num[i + j].ToString());
                product *= digit;
            }
            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }
        Console.WriteLine("Max Product: " + maxProduct);
        Console.ReadLine();
    }
}
