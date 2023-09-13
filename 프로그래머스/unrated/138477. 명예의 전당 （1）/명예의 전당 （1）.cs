using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        int[] answer = new int[score.Length];

        List<int> result = new List<int>();

        int min = 2000;

        for (int i = 0; i < score.Length; i++) //k번째까지는 answer배열에 min값을 넣고,
                                               //이후로는 수를 비교하여 넣기
        {
            result.Add(score[i]);

            if (i < k)
            {
                if (min > score[i])
                {
                    min = score[i];
                }

                answer[i] = min;
            }

            if(i >= k)
            {
                if (score[i] >= min)
                {
                    result.Sort();
                    result.RemoveAt(0);
                    min = result[0];
                    answer[i] = min;
                }
                else
                {
                    result.Remove(score[i]);
                    answer[i] = min;
                }
            }
        }

        return answer;
    }
}