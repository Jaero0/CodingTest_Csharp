class Solution {
    public int solution(int n) {
        int answer = 1;

        int multi = 1;

        if (n == 1) {
            return answer;
        }

        while (multi <= n) {
           
            multi *= answer;
            answer++;
        }

        return answer-2;
    }
}