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
            for (int j = i; j < count-1; j++)
            {
                sb.Append(" ");
            }

            for (int k = 0; k < i * 2 + 1; k++)
            {
                sb.Append("*");
            }
            sb.AppendLine();
        }

        for (int i = 0; i < count-1; i++)
        {
            for (int j = 0; j < i+1; j++)
            {
                sb.Append(" ");
            }
            for (int k = i*2-1; k < (count-1)*2-2; k++)
            {
                sb.Append("*");
            }
            sb.AppendLine();
        }
        Console.Write(sb);
    }
}