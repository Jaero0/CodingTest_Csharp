using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string solution(int[] food)
    {
        string answer = "";

        List<int> list = new List<int>();

        for (int i = 1; i < food.Length; i++)
        {
            int foodCount = food[i];
            if (foodCount % 2 != 0)
            {
                foodCount -= 1;
            }

            for (int j = 1; j <= foodCount / 2; j++)
            {
                list.Add(i);
            }
        }

        List<int> reverseList = new List<int>();
        reverseList = Enumerable.Reverse(list).ToList();

        list.Add(0);

        foreach (int i in reverseList)
        {
            list.Add(i);
        }

        foreach (int i in list)
        {
            answer += i.ToString();
        }

        return answer;
    }
}