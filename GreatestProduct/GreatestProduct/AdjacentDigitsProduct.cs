using System;
class AdjacentDigitProduct
{
    /// <summary>
    /// Finding the greatest from the products of every adjacent 4 digits of the input
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public long GreatestProduct(string num)
    {
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
        return maxProduct;
    }
}
