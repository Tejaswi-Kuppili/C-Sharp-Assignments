using System;

class Validation
{
    public int ValidationEdgeCases(string num)
    {
        if (num == null || num.Length < 4)
        {
            return 1;
        }
        else 
        {
            return 2;
        }
        
    }
}
