using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < count-1; j++)
            {
                sb.Append(" ");
            }
            sb.Append("*\n");
        }

        for (int i = 0; i < count-2; i++)
        {
            for (int j = i; j < count - 2; j++)
            {
                sb.Append(" ");
            }
             // 0 -> 3, 1 -> 5, 2 -> 7, 3 -> 9...
            for (int k = 0; k < i *2 +3; k++)
            {
                if (k == 0 || k == i * 2 + 2)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(" ");
                }
            }

            sb.Append("\n");
        }

        if (count > 1)
        {
            for (int i = 0; i < count * 2 - 1; i++)
            {
                sb.Append("*");
            }
        }

        Console.Write(sb);
    }
}