using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();

        string s = Console.ReadLine();
        int count = 0;

        foreach (char c in s)
        {
            sb.Append(c.ToString());
            count++;

            if (count == 10)
            {
                count = 0;
                sb.Append("\n");
            }
        }
        Console.WriteLine(sb);
    }
}