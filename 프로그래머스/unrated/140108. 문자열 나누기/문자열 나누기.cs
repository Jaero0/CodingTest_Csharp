public class Solution
{
    public int solution(string s)
    {
        int answer = 0;

        int firstCount = 0;
        int diffCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char first = s[i];

            for (int j = i; j < s.Length; j++)
            {
                if (s[j] == first)
                {
                    firstCount++;
                }
                else
                {
                    diffCount++;
                }

                if (firstCount == diffCount)
                {
                    firstCount = 0;
                    diffCount = 0;
                    answer++;
                    i = j;
                    break;
                }
            }
        }

        if (firstCount != diffCount)
        {
            return answer + 1;
        }
        return answer;
    }
}