class Solution {
    public int solution(int[] numbers) {

        int max = numbers[0];
        int secondMax = 0;

        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i] > max) {
                secondMax = max;
                max = numbers[i];
            } else if (numbers[i] > secondMax) {
                secondMax = numbers[i];
            }
        }
        return max * secondMax;
    }
}