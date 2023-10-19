using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
       List<string> croatian = new List<string>() { "c=", "c-", "d-", "lj", "nj", "s=", "z=", "dz=" };

        string input = Console.ReadLine();

        for (int i = croatian.Count-1; i >= 0 ; i--)
        {
            if (input.Contains(croatian[i]))
            {
                input = input.Replace(croatian[i], "1");
                croatian.Remove(croatian[i]);
            }
        }

        Console.WriteLine(input.Length);
    }
}