class Solution {
    public int[] solution(int[] num_list) {

        int length = num_list.length;
        int[] reversedArr = new int[length];

        for (int i = 0; i < length; i++) {
            
            reversedArr[i] = num_list[length-1-i];
        }

        return reversedArr;
    }
}