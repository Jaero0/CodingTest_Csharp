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
            for (int j = 0; j < i; j++) //blank
            {
                sb.Append(" ");
            }
            for (int k = count; k > i+1; k--)
            {
                sb.Append("*");
            }
            sb.Append("*");
            for (int m = count; m > i+1; m--)
            {
                sb.Append("*");
            }
            sb.Append("\n");
        }

        for (int i = 0; i < count-1; i++)
        {
            for (int j = i; j < count-2; j++)
            {
                sb.Append(" ");
            }
            for (int k = 0; k <= i; k++)
            {
                sb.Append("*");
            }
            sb.Append("*");
            for (int k = 0; k <= i; k++)
            {
                sb.Append("*");
            }
            sb.Append("\n");
        }
        Console.Write(sb);
    }
}