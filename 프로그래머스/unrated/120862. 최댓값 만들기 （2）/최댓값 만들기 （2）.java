import java.util.Arrays;

class Solution {
    public int solution(int[] numbers) {

        Arrays.sort(numbers);
        int l = numbers.length;

        int multiplePositive = numbers[l-1] * numbers[l-2];
        int multipleNegative = numbers[0] * numbers[1];

        return multipleNegative > multiplePositive ? multipleNegative : multiplePositive;
    }
}