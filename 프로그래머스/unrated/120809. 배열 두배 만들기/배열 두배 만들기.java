import java.util.LinkedList;
import java.util.List;

class Solution {
    public int[] solution(int[] numbers) {
        List<Integer> list = new LinkedList<>();

        for (int i : numbers) {
            list.add(i*2);
        }

        return list.stream().mapToInt(i->i).toArray();
    }
}