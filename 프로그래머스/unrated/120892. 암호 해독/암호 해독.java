class Solution {
    public String solution(String cipher, int code) {
        StringBuilder sb = new StringBuilder();

        int count = 0;
        for (char c : cipher.toCharArray()) {
            
            count++;
            if (count == code) {
                sb.append(c);
                count = 0;
            }
        }

        return sb.toString();
    }
}