using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int solution(int k, int m, int[] score)
    {
        int answer = 0;

        int left = score.Length % m;
        Array.Sort(score);
        List<int> listScore = score.ToList();

        for (int i = 0; i < left; i++)
        {
            listScore.RemoveAt(0);
        }

        List<int> boxSort = new List<int>();
        for (int i = 1; i <= listScore.Count; i++)
        {
            boxSort.Add(listScore[i - 1]);
            if (i % m == 0)
            {
                answer += boxSort[0] * m;
                boxSort.Clear();
                continue;
            }
        }


        return answer;
    }
}