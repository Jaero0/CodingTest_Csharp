using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        string wNumSum = "";
        string sum = "";

        string[] wordNumbs = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        foreach (char c in s)
        {
            wNumSum += c.ToString();
            int a;
            int.TryParse(wNumSum, out a);

            if (wordNumbs.Contains(wNumSum))
            {
                sum += Array.IndexOf(wordNumbs, wNumSum);
                wNumSum = "";
            }
            else if (int.TryParse(wNumSum, out a))
            {
                sum += a.ToString();
                wNumSum = "";
            }
            else
            {
                continue;
            }
        }

        return answer = int.Parse(sum);
    }
}