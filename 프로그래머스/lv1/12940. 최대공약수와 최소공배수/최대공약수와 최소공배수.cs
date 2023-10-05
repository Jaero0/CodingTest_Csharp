using System;

public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];

        answer[0] = GCD(n, m);
        answer[1] = LCM(n*m, answer[0]);

        return answer;
    }

    public int GCD(int n, int m)
    {
        if (n % m == 0)
        {
            return m;
        }
        else
        {
            return GCD(m, n % m);
        }
    }

    public int LCM(int n, int m)
    {
        return n / m;
    }
}