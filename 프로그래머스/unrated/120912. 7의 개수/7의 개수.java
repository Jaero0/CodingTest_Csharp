class Solution {
    public int solution(int[] array) {
        int answer = 0;

        for (int i = 0; i < array.length; i++) {
            
            char[] c = String.valueOf(array[i]).toCharArray();

            for (int j = 0; j < c.length; j++) {
                
                if (c[j] - '0' == 7) {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}