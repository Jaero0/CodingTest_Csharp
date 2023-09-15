using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Solution
{
    public int solution(int[] nums) 
    {
        int answer = 0;
        int count = nums.Length;

        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                for (int k = j + 1; k < count; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    if(CheckDivisorCount(sum) == 0)
                    {
                        answer++;
                    }
                }
            }

            if (i == count-3)
            {
                break;
            }
        }

        return answer;
    }

    int CheckDivisorCount(int num)
    {
        int sqrtNum = (int)MathF.Sqrt(num);

        int divisorCount = 0;

        for (int i = 2; i <= sqrtNum; i++)
        {
            if (num % i == 0)
            {
                divisorCount++;
            }
        }

        return divisorCount;
    }
}
