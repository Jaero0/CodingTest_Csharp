import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

class Solution {
    public int[] solution(String my_string) {

        List<Integer> answer = new LinkedList<>();

        for (char c : my_string.toCharArray()) {

            if ('0' <= c && '9' >= c) {
                answer.add(c-48);
            }
        }

        Collections.sort(answer);

        return answer.stream().mapToInt(i->i).toArray();
    }
}