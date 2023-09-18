public class Solution {
       public int solution(int num) {
        int answer = 0;
        long a = num;
        
        while(a != 1)
        {
            ++answer;
            
            if(a % 2 == 0)
            {
                a = a/2;
            }
            else 
            {
                a= (a*3)+1;
            }
            
            if(answer >= 500)
            {
                return -1;
            }
        }
        return answer;
    }
}