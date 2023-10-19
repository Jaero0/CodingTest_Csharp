using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string felindrom = "";
        for (int i = input.Length-1; i >= 0; i--)
        {
            felindrom += input[i];
        }

        if (input == felindrom)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}