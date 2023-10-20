using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
       int count = int.Parse(Console.ReadLine());

        List<Char> list = new List<Char>();
        int[] MODE = new int[26];

        bool isDuplicated = false;
        int groupWordCount = 0;

        for (int i = 0; i < count; i++)
        {
            string s = Console.ReadLine();

            for (int j = 0; j < s.Length-1; j++)
            {
                if (s[j] != s[j+1])
                {
                    list.Add(s[j]);
                }
            }
            list.Add(s[s.Length-1]);

            for (int j = 0; j < list.Count; j++)
            {
                MODE[(list[j] - 97)]++;
            }

            for (int j = 0; j < 26; j++)
            {
                if (MODE[j] > 1)
                {
                    isDuplicated = true;
                    break;
                }
            }

            if (!isDuplicated)
            {
                groupWordCount++;
            }

            list.Clear();
            MODE = new int[26];
            isDuplicated = false;
        }
        Console.WriteLine(groupWordCount);
    }
}