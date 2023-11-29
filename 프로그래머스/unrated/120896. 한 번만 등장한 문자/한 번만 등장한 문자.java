import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

class Solution {
    public String solution(String s) {
        StringBuilder sb = new StringBuilder();

        int[] mode = new int[26];

        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.length; i++) {

            alphabet[i] = (char)(i + 97);
        }

        char[] sChars = s.toCharArray();

        for (int i = 0; i < sChars.length; i++) {

            for (int j = 0; j < alphabet.length; j++) {

                if (sChars[i] == alphabet[j]) {
                    mode[j]++;
                    break;
                }
            }
        }

        List<Character> list = new LinkedList<>();
        for (int i = 0; i < alphabet.length; i++) {

            if (mode[i] == 1) {
                list.add(alphabet[i]);
            }
        }

        Collections.sort(list);
        for (Character c : list) {
            sb.append(c);
        }

        return sb.toString();
    }
}