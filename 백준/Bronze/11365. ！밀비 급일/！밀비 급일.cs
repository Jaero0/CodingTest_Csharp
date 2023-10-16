using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        Stack<char> stack = new Stack<char>();

        while (true)
        {
            string s = Console.ReadLine();

            if (s == "END")
                break;

            foreach (char c in s)
            {
                stack.Push(c);
            }
            for (int i = stack.Count-1; i >= 0; i--)
            {
                sb.Append(stack.Pop());
            }
            sb.Append('\n');
        }
        Console.WriteLine(sb);
    }
}