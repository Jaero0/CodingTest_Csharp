using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";

        char[] smallAlphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            smallAlphabet[i] = (char)(i + 97);
        }

        char[] bigAlphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            bigAlphabet[i] = (char)(i + 65);
        }

        char[] sChar = s.ToCharArray();

        foreach (char c in sChar)
        {
            if ('A' <= c && c <= 'Z')
            {
                if (c + n > 90)
                {
                    answer += ((char)(c + n - 26)).ToString();
                }
                else
                {
                    answer += ((char)(c + n)).ToString();
                }
            }
            else if ('a' <= c && c <= 'z')
            {
                if (c + n > 122)
                {
                    answer += ((char)(c + n - 26)).ToString();
                }
                else
                {
                    answer += ((char)(c + n)).ToString();
                }
            }
            else if (c == ' ')
            {
                answer += " ";
            }
        }
        return answer;
    }
}