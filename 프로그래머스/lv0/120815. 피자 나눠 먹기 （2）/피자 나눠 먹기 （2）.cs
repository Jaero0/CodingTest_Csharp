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

        int minimum = n % 6;

        if (minimum != 0)
        {
            while (6 % minimum != 0)
            {
                minimum = 6 % minimum;
            }
        }

        else
        {
            if (n > 6)
            {
                return answer = n / 6;
            }
            else
            {
                return answer = 1;
            }
        }


        int needPizzaPieces = (6 * n) / minimum;

        return answer = needPizzaPieces / 6;
    }
}