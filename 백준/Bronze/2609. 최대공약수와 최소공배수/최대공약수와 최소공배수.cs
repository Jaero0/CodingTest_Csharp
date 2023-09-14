using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        string[] ab = Console.ReadLine().Split();

        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);

        int GCD = GetGCD(a, b);
        int LCM = a * b / GCD;
        Console.Write(GCD + "\n" + LCM);
    }

    static int GetGCD(int a, int b)
    {
        if (a % b == 0)
        {
            return b;
        }
        else
        {
            return GetGCD(b, a % b);
        }
    }
}