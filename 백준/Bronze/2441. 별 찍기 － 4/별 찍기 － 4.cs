using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            for (int k = 0; k < i; k++)
            {
                sb.Append(" ");
            }
            for (int j = i; j < count; j++)
            {
                sb.Append("*");
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb);
    }
}