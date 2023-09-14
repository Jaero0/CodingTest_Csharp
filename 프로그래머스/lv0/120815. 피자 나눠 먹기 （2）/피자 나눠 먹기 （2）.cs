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

        int pizza = 6;

        int a = n;
        int b = 6;

        int gcd = GCD(a, b);
        int lcm = a * b / gcd;

        return lcm / b;
    }

    int GCD(int a, int b)
    {
        if (a % b == 0)
        {
            return b;
        }
        else
        {
            return GCD(b, a % b);
        }
    }
}