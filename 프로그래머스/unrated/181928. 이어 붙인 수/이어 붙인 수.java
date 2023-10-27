class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        StringBuilder evenSb = new StringBuilder();
        StringBuilder oddSb = new StringBuilder();
        int evenNum;
        int oddNum;

        for (int i = 0; i < num_list.length; i++) {
            if (num_list[i]%2 == 0) {
                evenSb.append(num_list[i]);
            } else {
                oddSb.append(num_list[i]);
            }
        }
        
        evenNum = Integer.parseInt(evenSb.toString());
        oddNum = Integer.parseInt(oddSb.toString());

        return answer = evenNum + oddNum;
    }
}