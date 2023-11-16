class Solution {
    public int[] solution(String[] strlist) {
        int[] answer = new int[strlist.length];

        for (int j = 0; j < strlist.length; j++) {

            int count = strlist[j].length();
            answer[j] = count;
        }

        return answer;
    }
}