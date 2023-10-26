import java.util.ArrayList;
import java.util.List;

class Solution {
    public int solution(int[] num_list, int n) {
        int answer = 0;

        List<Integer> list = new ArrayList<>();
        for (int i = 0; i < num_list.length; i++) {
            list.add(num_list[i]);
        }

        return answer = list.indexOf(n) >= 0 ? 1: 0;
    }
}