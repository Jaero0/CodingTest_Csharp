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
            for (int k = count-i; k < count; k++)
            {
                sb.Append("*");
            }

            sb.Append("*");

            for (int m = count - i; m < count; m++)
            {
                sb.Append("*");
            }

            if (i == count - 1)
                break;
            sb.Append("\n");
        }
        Console.Write(sb);
    }
}