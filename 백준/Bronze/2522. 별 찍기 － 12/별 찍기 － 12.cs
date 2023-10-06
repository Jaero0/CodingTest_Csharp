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
                Console.Write(" ");
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < count-1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < count - i-1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}