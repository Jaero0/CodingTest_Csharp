using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string s)
    {
        List<int> answer = new List<int>();

        List<char> chars = s.ToCharArray().ToList();

        List<char> list = new List<char>();

        for (int i = chars.Count - 1; i >= 0; i--)
        {
            bool isThere = false;
            list.Add(chars[i]);

            for (int j = i - 1; j >= 0; j--)
            {
                if (chars[j] == list[0])
                {
                    answer.Add(i - j);
                    chars.RemoveAt(i);
                    list.Clear();
                    isThere = true;
                    break;
                }
            }
            if (!isThere)
            {
                chars.RemoveAt(i);
                list.Clear();
                answer.Add(-1);
            }
        }

        answer.Reverse();

        return answer.ToArray();
    }
}