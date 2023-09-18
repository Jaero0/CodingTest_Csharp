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

        int a = int.Parse(Console.ReadLine());
        for (int i = 0; i < a; i++)
        {
            string[] str = Console.ReadLine().Split(",");

            sb.Append(int.Parse(str[0]) + int.Parse(str[1]) + "\n");
        }

        Console.WriteLine(sb.ToString());
    }
}