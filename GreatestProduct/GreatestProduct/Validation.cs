using System;

class Validation
{
    public int ValidationEdgeCases(string num)
    {
        if (num == string.Empty || num.Length < 4)
        {
            return 1;
        }
        else 
        {
            return 2;
        }
        
    }
}
