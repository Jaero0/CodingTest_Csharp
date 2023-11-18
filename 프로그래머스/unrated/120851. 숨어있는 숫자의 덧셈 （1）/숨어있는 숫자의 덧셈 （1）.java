class Solution {
    public int solution(String my_string) {
        int answer = 0;

        for (char c : my_string.toCharArray()) {
            
            if (0 <= c-48 && c-48 <= 9) {
                answer += c-48;
            }
        }
        
        return answer;
    }
}