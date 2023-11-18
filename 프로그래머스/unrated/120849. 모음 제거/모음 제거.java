class Solution {
    public String solution(String my_string) {
        
        char[] c = my_string.toCharArray();
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < c.length; i++) {
             
            if (c[i] == 'a' || c[i] == 'e' || c[i] == 'o' || c[i] == 'i' || c[i] == 'u') {
                continue;
            }
            sb.append(c[i]);
        }
        
        return sb.toString();
    }
}