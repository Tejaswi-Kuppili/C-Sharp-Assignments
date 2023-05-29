using System;

public class Validation
{
    public int ValidationEdgeCases(string str1, string str2)
    {
        if (str1 == string.Empty && str2 == string.Empty)
        {
            return 0;
        }
        else if(str1 == string.Empty)
        {
            return 1;
        }
        else if (str2 == string.Empty)
        {
            return 2;
        }
        else if (str1.Length <str2.Length)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
}
