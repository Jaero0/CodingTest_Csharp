class Solution {
    public int[] solution(int[] numbers, String direction) {

        int l = numbers.length;

        int[] answer = new int[l];

        if (direction.equals("left")) {

            for (int i = 0; i < l-1; i++) {

                answer[i] = numbers[i+1];
            }

            answer[l-1] = numbers[0];
        } else {

            for (int i = 0; i < l-1; i++) {
                
                answer[i+1] = numbers[i];
            }

            answer[0] = numbers[l-1];
        }

        return answer;
    }
}