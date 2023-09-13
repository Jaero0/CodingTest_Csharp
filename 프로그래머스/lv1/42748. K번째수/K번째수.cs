using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        List<int> answer = new List<int>();


        for (int i = 0; i < commands.GetLength(0); i++)
        {
            List<int> list = new List<int>();

            int a = commands[i, 0];
            int b = commands[i, 1];
            int c = commands[i, 2];

            int[] newArray = new int[b - a + 1];

            newArray = array.Skip(a - 1).Take(b - a + 1).ToArray();

            newArray = newArray.OrderBy(x => x).ToArray();

            for (int j = 0; j < newArray.Length; j++)
            {
                list.Add(newArray[j]);
            }

            for (int k = list.Count - 1; k >= 0; k--)
            {
                if (k != c - 1)
                {
                    list.RemoveAt(k);
                }
                else if (k == c - 1)
                {
                    continue;
                }
            }

            answer.Add(list[0]);


        }
        return answer.ToArray();
    }
}