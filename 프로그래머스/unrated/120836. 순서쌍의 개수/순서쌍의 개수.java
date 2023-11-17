class Solution {
    public int solution(int n) {
        int answer = 0;

        int sqrt = (int)Math.sqrt(n);

        for (int i = 1; i <= sqrt; i++) {

            if (n % i == 0) {
                answer++;
            }
        }

        return n % Math.sqrt(n) == 0 ? answer * 2 - 1 : answer * 2;
    }
}