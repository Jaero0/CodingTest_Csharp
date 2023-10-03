using System;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int[] answer = new int[2];

        int numerator = denom1 * numer2 + denom2 * numer1;
        int denominator  = denom1 * denom2;

        for (int i = 1; i < numerator + denominator; i++)
        {
            if(numerator % i == 0 && denominator % i == 0)
            {
                answer[0] = numerator / i;
                answer[1] = denominator / i;
            }
        }

        return answer;

    }
}