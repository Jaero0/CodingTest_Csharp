using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        string answer = "";
        bool isOrdered = true;
        bool ndIsOrdered = true;
        bool goalContained = true;

        int firstIndex = 0;
        int secondIndex = 0;

        int ndFirstIndex = 0;
        int ndSecondIndex = 0;


        foreach (string card in goal)
        {
            if (cards1.Contains(card))
            {
                secondIndex = firstIndex; //1 -> 5
                firstIndex = Array.IndexOf(cards1, card) + 1; //5 -> 3

                if (firstIndex != secondIndex + 1)
                {
                    isOrdered = false;
                    break;
                }
            }

            if (cards2.Contains(card))
            {
                ndSecondIndex = ndFirstIndex; //0 -> 2
                ndFirstIndex = Array.IndexOf(cards2, card) + 1; //2 -> 3

                if (ndFirstIndex != ndSecondIndex + 1)
                {
                    ndIsOrdered = false;
                    break;
                }
            }
        }

        if (!isOrdered || !ndIsOrdered || !goalContained)
        {
            return answer = "No";
        }
        else
        {
            return answer = "Yes";
        }
    }
}