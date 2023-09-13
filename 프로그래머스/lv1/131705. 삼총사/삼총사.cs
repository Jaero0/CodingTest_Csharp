using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] number)
    {
        int count = 0;

        for (int i = 0; i < number.Length; i++)
        {
            for (int j = 1 + i; j < number.Length; j++)
            {
                for (int k = 1 + j; k < number.Length; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }
}