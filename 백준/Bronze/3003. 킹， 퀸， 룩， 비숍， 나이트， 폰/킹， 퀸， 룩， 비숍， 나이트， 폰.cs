using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        int[] origin = { 1, 1, 2, 2, 2, 8 };

        string[] input = Console.ReadLine().Split();
        int length = input.Length;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
            {
                sb.Append(origin[i] - int.Parse(input[i]));
                break;
            }
            sb.Append(origin[i] - int.Parse(input[i]) + " ");
        }
        Console.WriteLine(sb);
    }
}