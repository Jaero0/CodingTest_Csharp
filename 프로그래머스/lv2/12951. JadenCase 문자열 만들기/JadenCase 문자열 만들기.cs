using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        string[] sArr = s.Split();

        for (int i = 0; i < sArr.Length; i++)
        {
            for (int j = 0; j < sArr[i].Length; j++)
            {
                if (j == 0)
                {
                    if (48<=sArr[i][j] && sArr[i][j] <= 57)
                    {
                        answer += sArr[i][j].ToString();
                    }
                    else
                    {
                        answer += sArr[i][j].ToString().ToUpper();
                    }
                }
                else
                {
                    answer += sArr[i][j].ToString().ToLower();
                }
            }
            if(i < sArr.Length - 1)
                answer += " ";
        }

        return answer;
    }
}