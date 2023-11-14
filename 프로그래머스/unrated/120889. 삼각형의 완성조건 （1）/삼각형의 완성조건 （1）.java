class Solution {
    public int solution(int[] sides) {
        
        int max = 0;
        int sum = 0;
        for (int i : sides) {
            if (i > max) {
                max = i;
            }
            sum += i;
        }
        
        return sum - max > max ? 1 : 2;
    }
}