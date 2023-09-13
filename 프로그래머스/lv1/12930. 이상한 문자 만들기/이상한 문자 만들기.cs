using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();

        string[] sa = s.Split();

        for (int i = 0; i < sa.Length; i++)
        {
            char[] chars = new char[sa[i].Length];

            for (int j = 0; j < sa[i].Length; j++)
            {
                chars[j] = sa[i][j];
            }

            for (int k = 0; k < chars.Length; k++)
            {
                if (k % 2 == 0)
                {
                    sb.Append(chars[k].ToString().ToUpper());
                }
                else
                {
                    sb.Append(chars[k].ToString().ToLower());
                }
            }
            if (i == sa.Length-1)
            {
                break;
            }
            sb.Append(" ");
        }
        return sb.ToString();
    }
}