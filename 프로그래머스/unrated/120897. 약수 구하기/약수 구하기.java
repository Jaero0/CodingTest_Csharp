import java.util.LinkedList;
import java.util.List;

class Solution {
    public int[] solution(int n) {
        int[] answer = {};

        List<Integer> list = new LinkedList<>();
        list.add(1);

        for (int i = 2; i <= n; i++) {
            
            if (n % i == 0) {
                list.add(i);
            }
        }
        
        return list.stream().mapToInt(i->i).toArray();
    }
}