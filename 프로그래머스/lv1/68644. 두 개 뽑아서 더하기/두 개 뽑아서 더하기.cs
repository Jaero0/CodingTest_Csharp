using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        List<int> result = new List<int>();
        List<int> list = new List<int>();
        list = numbers.ToList();

        for (int i = list.Count - 1; i >= 0; i--)
        {
            int last = list[i];
            list.Remove(last);
            foreach (int n in list)
            {
                result.Add(n + last);
            }
        }

        result = result.Distinct().OrderBy(x => x).ToList();

        return result.ToArray();
    }
}