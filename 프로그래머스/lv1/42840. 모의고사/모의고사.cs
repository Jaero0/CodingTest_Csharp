using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        List<int> answer = new List<int>();

        int[] student1 = { 1, 2, 3, 4, 5 };
        int[] student2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] student3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] score = new int[3];

        int max = 0;

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == student1[i % 5])
                score[0] += 1;

            if (answers[i] == student2[i % 8])
                score[1] += 1;

            if (answers[i] == student3[i % 10])
                score[2] += 1;
        }

        max = score.Max();

        for (int i = 0; i < 3; i++)
        {
            if (max == score[i])
            {
                answer.Add(i + 1);
            }
        }

        return answer.ToArray();
    }
}