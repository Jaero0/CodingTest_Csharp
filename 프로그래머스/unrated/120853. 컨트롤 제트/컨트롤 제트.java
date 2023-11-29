class Solution {
    public int solution(String s) {
        int answer = 0;

        int temp = 0;
        String[] tokens = s.split(" ");

        for (int i = 0; i < tokens.length; i++) {
            
            if (tokens[i].equals("Z")) {
                answer -= temp;
                continue;
            }
            int plus = Integer.parseInt(tokens[i]);
            
            answer += plus;
            temp = plus;
        }
        
        return answer;
    }
}