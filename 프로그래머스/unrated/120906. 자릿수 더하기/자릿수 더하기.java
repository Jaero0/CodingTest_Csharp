class Solution {
    public int solution(int n) {
        int answer = 0;

        char[] c = (String.valueOf(n)).toCharArray();

        for (char c1 : c) {
            answer += c1 - 48;
        }

        return answer;
    }
}