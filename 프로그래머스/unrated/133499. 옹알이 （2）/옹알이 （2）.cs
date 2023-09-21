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

        string s;

        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < baby.Length; j++)
            {
                string multiple = baby[j] + baby[j];
                babbling[i] = babbling[i].Replace(multiple, "1");
                babbling[i] = babbling[i].Replace(baby[j], " ");
            }

            if (babbling[i].Trim() == "")
            {
                answer++;
            }
        }

        return answer;
    }
}