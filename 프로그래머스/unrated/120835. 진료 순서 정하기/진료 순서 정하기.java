import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

class Solution {
    public int[] solution(int[] emergency) {

        int[] answer = new int[emergency.length];

        List<Integer> emeList = Arrays.stream(emergency).boxed().collect(Collectors.toList());

        List<Integer> sortedList = Arrays.stream(emergency).sorted().boxed().collect(Collectors.toList());
        Collections.reverse(sortedList);

        for (int i = 0; i < sortedList.size(); i++) {

            answer[i] = sortedList.indexOf(emeList.get(i)) + 1;
        }
        return answer;
    }
}