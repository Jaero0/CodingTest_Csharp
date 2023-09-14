using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        int defaultPizzaPieces = 6;

        int minimum;

        if (n >= defaultPizzaPieces)
        {
            minimum = n % defaultPizzaPieces;
        }
        else
        {
            minimum = defaultPizzaPieces % n;
        }

        if (minimum != 0)
        {
            if (n >= defaultPizzaPieces)
            {
                while (defaultPizzaPieces % minimum != 0)
                {
                    minimum = defaultPizzaPieces % minimum;
                }
            }
            else
            {
                while (n % minimum != 0)
                {
                    minimum = n % minimum;
                }
            }
        }
        else
        {
            if (n >= defaultPizzaPieces)
            {
                return answer = n / defaultPizzaPieces;
            }
            else
            {
                return answer = 1;
            }
        }

        int needPizzaPieces = (defaultPizzaPieces * n) / minimum;

        return answer = needPizzaPieces / defaultPizzaPieces;
    }
}