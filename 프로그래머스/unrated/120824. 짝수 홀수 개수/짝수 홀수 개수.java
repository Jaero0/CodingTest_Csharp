class Solution {
    public int[] solution(int[] num_list) {
        
        int l = num_list.length;
        int[] answer = new int[2];
        
        for (int i = 0; i < l; i++) {
            
            answer[num_list[i]%2]++;
        }
        
        return answer;
    }
}