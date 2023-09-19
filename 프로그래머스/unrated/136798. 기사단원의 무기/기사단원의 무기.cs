using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;
        List<int> divisorList = new List<int>(); //약수개수 담을 리스트
        divisorList.Add(1); //먼저 1 추가하기

        for (int i = 2; i <= number; i++)
        {
            int divisorCount = 0;
            int sqrtI = (int)MathF.Sqrt(i);

            for (int j = 1; j <= sqrtI; j++)
            {
                if (i % j == 0)
                {
                    divisorCount += 2;
                }
            }

            if (i % MathF.Sqrt(i) == 0)
            {
                divisorCount -= 1;
            }

            divisorList.Add(divisorCount);
        }

        foreach (int divisor in divisorList)
        {
            if (divisor <= limit)
            {
                answer += divisor;
            }
            else
            {
                answer += power;
            }
        }

        return answer;
    }
}