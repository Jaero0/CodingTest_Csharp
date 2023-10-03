using System;

public class Solution
{
    public int solution(int[] array)
    {
        int[] index = new int[1001];
        int max = 0;
        int indexWhere = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = index[array[i]]++;
        }

        for (int i = 0; i < index.Length; i++)
        {
            if (max < index[i])
            {
                max = index[i];
                indexWhere = i;
            }
            else if (max == index[i])
            {
                indexWhere = -1;
            }
        }

        return indexWhere;
    }
}