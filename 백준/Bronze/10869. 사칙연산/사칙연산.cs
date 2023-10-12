using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] AoB = Console.ReadLine().Split();
        int A = int.Parse(AoB[0]);
        int B = int.Parse(AoB[1]);

        sb.Append(A + B + "\n");
        sb.Append(A - B+ "\n");
        sb.Append(A * B+ "\n");
        sb.Append(A / B + "\n");
        sb.Append(A % B);
        Console.Write(sb);
    }
}