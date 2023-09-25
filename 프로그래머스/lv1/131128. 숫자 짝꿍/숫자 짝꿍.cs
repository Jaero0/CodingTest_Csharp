using System;
using System.Text;

using System;

public class Solution
{
    public string solution(string X, string Y)
    {
        string answer = "";
        int[] a = new int[10]; //0~9 자연수 갯수 담을 최빈값 알고리즘 배열
        int[] b = new int[10];

        for (int i = 0; i < X.Length; i++)
        {
            a[(int)(X[i] - 48)]++;
        }
        for (int i = 0; i < Y.Length; i++)
        {
            b[(int)(Y[i] - 48)]++;
        }

        StringBuilder pair = new StringBuilder();

        for (int i = 9; i >= 0; i--) //자동으로 숫자 갯수만큼 정렬되어있으니, 
        {
            while (a[i] > 0 && b[i] > 0) //두 배열안에 같은 값이 들어있을때 pair에 합쳐줌
            {
                pair.Append(i);
                a[i]--;
                b[i]--;
            }
        }

        if (string.IsNullOrEmpty(pair.ToString()))
        {
            return "-1";
        }
        else if("0".Equals(pair.ToString().Substring(0, 1))) // 첫 시작이 0일때,
        {
            return "0";
        }
        else
        {
            return pair.ToString(); 
        }
    }
}