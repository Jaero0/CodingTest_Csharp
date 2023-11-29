import java.util.Stack;

class Solution {
    public int solution(String s) {
        int answer = 0;

        Stack<String> stack = new Stack<>();

        String[] tokens = s.split(" ");
        for (String token : tokens) {

            if (token.equals("Z")) {
                stack.pop();
            } else {
                stack.push(token);
            }
        }

        while (!stack.isEmpty()) {
            answer += Integer.parseInt(stack.pop());
        }

        return answer;
    }
}