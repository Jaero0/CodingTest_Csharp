using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int stolen = 0;
        n = n - lost.Length;

        List<int> lostList = lost.OrderBy(x => x).ToList();
        List<int> reserveList = reserve.OrderBy(x => x).ToList();

        for (int i = reserveList.Count - 1; i >= 0; i--)
        {
            for (int j = lostList.Count - 1; j >= 0; j--)
            {
                if (reserveList[i] == lostList[j])
                {
                    reserveList.RemoveAt(i);
                    lostList.RemoveAt(j);
                    stolen++;
                    break;
                }
            }
        }

        n += stolen;

        for (int i = reserveList.Count - 1; i >= 0; i--)
        {
            for (int j = lostList.Count - 1; j >= 0; j--)
            {
                if (reserveList[i] + 1 == lostList[j] || reserveList[i] - 1 == lostList[j])
                {
                    n++;
                    lostList.RemoveAt(j);
                    reserveList.RemoveAt(i);
                    break;
                }
            }
        }

        return n;
    }
}