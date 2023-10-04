using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                sb.Append("*");
            }
            for (int k = count*2; k > i*2; k--)
            {
                sb.Append(" ");
            }
            for(int n = 1; n <= i; n++)
            {
                sb.Append("*");
            }
            sb.Append("\n");
        }

        for (int i = count - 1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                sb.Append("*");
            }
            for (int k = count * 2; k > i * 2; k--)
            {
                sb.Append(" ");
            }
            for (int n = 1; n <= i; n++)
            {
                sb.Append("*");
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb);
    }
}