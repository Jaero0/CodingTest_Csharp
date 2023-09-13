using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;

        char[] chars = t.ToCharArray();
        long tLen = t.Length;
        long pLen = p.Length;

        for (int i = 0; i < tLen - pLen + 1; i++)
        {
            string three = "";

            for (int j = 0; j < pLen; j++)
            {
                three += chars[j+i].ToString();
            }

            if (long.Parse(three) <= long.Parse(p))
            {
                answer++;
            }
        }

        return answer;
    }
}