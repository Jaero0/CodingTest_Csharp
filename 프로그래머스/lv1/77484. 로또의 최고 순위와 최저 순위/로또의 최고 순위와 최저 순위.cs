using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[2];

        List<int> repeatedLottoNums = new List<int>();
        int zeroCount = 0;

        foreach (int lotto in lottos)
        {
            foreach (int win in win_nums)
            {
                if ( lotto == win)
                {
                    repeatedLottoNums.Add(win); //최소 중복 개수 = 최저점수
                    break;
                }
            }
            if (lotto == 0)
            {
                zeroCount++;
            }
        }


        answer[0] = 6 - (repeatedLottoNums.Count + zeroCount) + 1;

        answer[1] = 6 - repeatedLottoNums.Count + 1;

        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] > 6)
            {
                answer[i] = 6;
            }
        }

        return answer;
    }
}