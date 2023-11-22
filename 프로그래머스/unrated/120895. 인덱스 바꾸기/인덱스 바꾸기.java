class Solution {
    public String solution(String my_string, int num1, int num2) {
        
        StringBuilder sb = new StringBuilder();

        char f = my_string.charAt(num1);
        char s = my_string.charAt(num2);
        
        char[] chars = my_string.toCharArray();

        for (int i = 0; i < chars.length; i++) {
            
            if (i == num1) {
                sb.append(s);
                continue;
            } else if (i == num2) {
                sb.append(f);
                continue;
            }
            sb.append(chars[i]);
        }

        return sb.toString();
    }
}