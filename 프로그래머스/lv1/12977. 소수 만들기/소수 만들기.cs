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
        List<int> listNums = nums.ToList();

        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                for (int k = j + 1; k < count; k++)
                {
                    int sum = listNums[i] + listNums[j] + listNums[k];
                    int sqrtSum = (int)MathF.Sqrt(sum);

                    int divisorCount = 0;

                    for (int z = 1; z <= sqrtSum; z++)
                    {
                        if (sum % z == 0)
                        {
                            divisorCount++;
                        }
                    }

                    if(divisorCount == 1)
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
}
