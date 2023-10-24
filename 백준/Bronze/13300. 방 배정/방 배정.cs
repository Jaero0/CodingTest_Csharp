using System;
using System.Text;

public class Solution
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int studentCount = int.Parse(input[0]);
        int roomPerStudent = int.Parse(input[1]);

        List<string> list = new List<string>();

        for (int i = 0; i < studentCount; i++)
        {
            string sexoGrade = Console.ReadLine();
            list.Add(sexoGrade);
        }
        
        List<int> girlGrade = new List<int>();
        List<int> boyGrade = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (int.Parse(list[i].Split()[0]) == 0)
            {
                girlGrade.Add(int.Parse(list[i].Split()[1]));
            }
            else
            {
                boyGrade.Add(int.Parse(list[i].Split()[1]));
            }
        }

        int roomCount = 0;

        girlGrade.Sort();
        boyGrade.Sort();

        for (int i = girlGrade.Count -1; i >= 1; i--)
        {
            if (girlGrade[i] == girlGrade[i-1])
            {
                girlGrade.RemoveAt(i);
                roomCount++;
                if (roomCount == roomPerStudent-1)
                {
                    roomCount = 0;
                    i--;
                }
            }
        }

        roomCount = 0;

        for (int i = boyGrade.Count - 1; i >= 1; i--)
        {
            if (boyGrade[i] == boyGrade[i - 1])
            {
                boyGrade.RemoveAt(i);
                roomCount++;
                if (roomCount == roomPerStudent - 1)
                {
                    roomCount = 0;
                    i--;
                }
            }
        }

        Console.WriteLine(girlGrade.Count + boyGrade.Count);
    }
}