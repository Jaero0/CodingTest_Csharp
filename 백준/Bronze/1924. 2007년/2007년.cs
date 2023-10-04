using System;

public class Solution
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int goalMonth = int.Parse(s[0]);
        int goalDate = int.Parse(s[1]);


        int[] datesInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] days = {"MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"};

        int totalDates = 0;

        for (int i = 0; i < datesInMonth.Length; i++)
        {
            if (i+1 >= goalMonth)
            {
                break;
            }
            totalDates += datesInMonth[i];
        }
        totalDates += goalDate;

        int divideDates = totalDates % 7;

        if(divideDates == 0)
        {
            Console.WriteLine(days[6]);
        }
        else
        {
            Console.WriteLine(days[divideDates - 1]);
        }
    }
}