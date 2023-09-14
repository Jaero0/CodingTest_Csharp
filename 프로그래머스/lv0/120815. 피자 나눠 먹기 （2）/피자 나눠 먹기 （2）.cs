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
        int answer = 1;

        while (true)
        {
            if (6 * answer % n == 0)
                break;
            answer++;
        }

        return answer;
    }
}