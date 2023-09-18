public class Solution
{
    public int solution(int num)
    {
        int answer = 0;
        bool isOne = false;

        for (int i = 0; i < 500; i++)
        {
            if (num < 0)
            {
                break;
            }
            else if (num == 1)
            {
                isOne = true;
                break;
            }
            else if (num % 2 == 0)
            {
                num = num / 2;
                answer++;
            }
            else
            {
                num = num * 3 + 1;
                answer++;
            }

            if (num == 1)
            {
                isOne = true;
                break;
            }
        }

        if (isOne)
        {
            return answer;
        }
        else
        {
            return -1;
        }
        
    }
}