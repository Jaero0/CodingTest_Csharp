using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int devide = 0;
        string three = "";

        while (n != 0)
        {
            three += (n % 3).ToString();
            n /= 3;
        }

        char[] chars = three.ToCharArray();
        Array.Reverse(chars);

        for (int i = chars.Length-1; i >= 0; i--)
        {
            answer += (chars[i] - '0') * (int)Math.Pow(3, i);
        }
        
        return answer;
    }
}