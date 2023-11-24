
import java.util.stream.Collectors;

class Solution {
    public int solution(String before, String after) {
        int answer = 0;

        before = beforeAfter(before);
        after = beforeAfter(after);


        System.out.println(before);
        System.out.println(after);

        return before.equals(after) ? 1 : 0;
    }

    public String beforeAfter(String s) {
        return s.chars().sorted().mapToObj(c -> String.valueOf((char) c))
                .collect(Collectors.joining());
    }
}