class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;

        for (int l = i; l <= j; l++) {

            char[] chars = String.valueOf(l).toCharArray();

            for (char aChar : chars) {

                if (aChar-48 == k) {
                    answer++;
                }
            }
        }

        return answer;
    }
}