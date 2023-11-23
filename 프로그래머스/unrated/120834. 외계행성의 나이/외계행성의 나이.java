class Solution {
    public String solution(int age) {

        StringBuilder sb = new StringBuilder();
        
        char[] alphabet = new char[26];

        for (int i = 0; i < alphabet.length; i++) {

            alphabet[i] = (char)(i + 'a');
        }


        String v = String.valueOf(age);

        for (char c : v.toCharArray()) {

            sb.append(alphabet[c-48]);
        }
        
        return sb.toString();
    }
}