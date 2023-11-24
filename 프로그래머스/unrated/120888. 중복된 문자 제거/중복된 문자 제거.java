class Solution {
    public String solution(String my_string) {
        
        StringBuilder sb = new StringBuilder();
        char[] chars = my_string.toCharArray();

        for (char aChar : chars) {
            
            if (sb.toString().contains(String.valueOf(aChar))) {
                
                continue;
            } else {
                sb.append(aChar);
            }
        }
        
        return sb.toString();
    }
}