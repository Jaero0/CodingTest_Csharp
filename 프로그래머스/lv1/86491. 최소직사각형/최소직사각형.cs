using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int answer = 0;
        int horizon = 0;
        int vertical = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int max = Math.Max(sizes[i,0], sizes[i, 1]);
            int min = Math.Min(sizes[i, 0], sizes[i, 1]);

            if (horizon < max)
            {
                horizon = max;
            }
            if (vertical < min)
            {
                vertical = min;
            }
        }



        return answer = horizon * vertical;
    }
}