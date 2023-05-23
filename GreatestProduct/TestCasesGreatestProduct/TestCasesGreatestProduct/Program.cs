using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public class testcase1
    {
        public testcase1()
        {
            string num = "136467387213647";
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
        }
    }
    public class testcase2
    {
        public testcase2()
        {
            string num = "452187214697";
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
        }
    }
    public class testcase3
    {
        public testcase3()
        {
            string num = "35412789154245124831";
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
    public static void Main(string[] args)
    {
        testcase1 t1 = new testcase1();
        testcase2 t2 = new testcase2();
        testcase3 t3 = new testcase3();
    }
}
