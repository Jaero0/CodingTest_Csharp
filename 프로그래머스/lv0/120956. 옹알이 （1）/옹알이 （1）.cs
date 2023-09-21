using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;

        string[] baby = { "aya", "ye", "woo", "ma" };

        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < baby.Length; j++)
            {
                babbling[i] = babbling[i].Replace(baby[j], "1");
            }

            if (babbling[i].Trim('1') == "")
            {
                answer++;
            }
        }

        return answer;
    }
}