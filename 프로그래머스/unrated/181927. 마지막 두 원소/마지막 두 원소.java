class Solution {
    public int[] solution(int[] num_list) {
        int length = num_list.length;
        int[] answer = new int[length+1];

        int finalNum = 0;
        if (num_list[length-1] >
                num_list[length-2]) {
            finalNum = num_list[length-1] - num_list[length-2];
        } else {
            finalNum = num_list[length-1] *2;
        }

        System.arraycopy(num_list, 0, answer, 0, length);
        answer[length] = finalNum;
        return answer;
    }
}