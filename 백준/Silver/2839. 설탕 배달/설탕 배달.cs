class BJ
{
    static void Main()
    {
        int kg = int.Parse(Console.ReadLine());

        int min = 1666;
        bool isTrue = false;

        for (int i = 0; i <= 1000; i++)
        {
            if (i * 5 == kg)
            {
                min = i;
                break;
            }
            else if(i * 5 > kg)
            {
                break;
            }

            for (int j = 1; j <= 1666; j++)
            {
                if (3 * j > kg)
                {
                    break;
                }
                else if (5 * i + 3 * j == kg)
                {
                    if (min > i + j)
                    {
                        min = i + j;
                        break;
                    }
                }
            }
        }

        if(min == 1666)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(min);
        }
    }
}