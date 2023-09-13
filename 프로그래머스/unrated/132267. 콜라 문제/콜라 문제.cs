using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int solution(int a, int b, int n)
    {
        int answer = 0;

        while (a <= n)
        {
            int count = (n / a) * b;
            int left = n % a;

            n = count + left;

            answer += count;
        }

        return answer;
    }
}
