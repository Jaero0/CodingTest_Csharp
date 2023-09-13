using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];

        int min = 0;
        int max = 0;

        if (n > m)
        {
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    if (i > max)
                    {
                        max = i;
                    }

                }
                else if (i > m)
                {
                    break;
                }
            }

            int asd = m;

            while (true)
            {

                if (asd % n == 0 && asd % m == 0)
                {
                    min = asd;
                    break;
                }
                asd++;
            }
        }

        else if (n < m)
        {
            for (int i = 1; i < m; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    if (i > max)
                    {
                        max = i;
                    }

                }
                else if (i > n)
                {
                    break;
                }
            }

            int asd = m;

            while (true)
            {

                if (asd % n == 0 && asd % m == 0)
                {
                    min = asd;
                    break;
                }
                asd++;
            }
        }

        answer[0] = max;
        answer[1] = min;


        return answer;
    }
}