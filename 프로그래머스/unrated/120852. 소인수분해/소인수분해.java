import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

class Solution {
    public int[] solution(int n) {
        int[] answer = {};
        StringBuilder sb = new StringBuilder();

        List<Integer> list = new LinkedList<>();

        int count = 2;


        while (n >= count) {

            if (n % count == 0) {
                list.add(count);
            }
            count++;
        }
        
        for (int i = 0; i < list.size(); i++) {

            int sqrt = (int)Math.sqrt(list.get(i));
            count = 0;

            for (int j = 2; j <= sqrt; j++) {
                
                if (list.get(i) % j == 0) {
                    count++;
                }
            }
            
            if (count == 0) {
                sb.append(list.get(i)).append(" ");
            }
        }
        
        answer = Arrays.stream(sb.toString().split(" ")).mapToInt(Integer::parseInt).toArray();
        return answer;
    }
}