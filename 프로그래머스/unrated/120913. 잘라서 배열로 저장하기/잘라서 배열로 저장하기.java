class Solution {
    public String[] solution(String my_str, int n) {
        
        StringBuilder sb = new StringBuilder();
        
        char[] chars = my_str.toCharArray();
        int count = 1;
        
        for (int i = 0; i < chars.length; i++) {
            
            if (count < n) {
                sb.append(chars[i]);
                count++;
                continue;
            }
            
            if (count == n) {
                sb.append(chars[i]).append(" ");
                count = 1;
            }
        }
        
        return sb.toString().split(" ");
    }
}