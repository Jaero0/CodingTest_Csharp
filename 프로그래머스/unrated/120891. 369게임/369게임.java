class Solution {
    public int solution(int order) {
        int answer = 0;

        String s = String.valueOf(order);

        for (char c : s.toCharArray()) {
            
            if ((c-48) % 3 == 0 && c - 48 != 0) {
                answer++;
            }
        }

        return answer;
    }
}