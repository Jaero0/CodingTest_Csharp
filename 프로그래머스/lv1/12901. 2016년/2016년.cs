using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string solution(int a, int b)
    {
        //1 fri 2 sat 3 sun 4 mon 5 tue 6 wed 7 thu

        string answer = "";

        int[] daysInMonths = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] dia = { "THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED" };

        int days = 0;
        for (int i = 0; i < a-1; i++)
        {
            days += daysInMonths[i];
        }
        days += b;

        int whichDay = days % 7;

        return answer = dia[whichDay];
    }
}