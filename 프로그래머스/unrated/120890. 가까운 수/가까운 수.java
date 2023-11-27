import java.util.Arrays;
import java.util.stream.Collectors;

class Solution {
    public int solution(int[] array, int n) {

        int l = array.length;
        int[] minus = new int[l];
        
        Arrays.sort(array);

        for (int i = 0; i < l; i++) {

            minus[i] = Math.abs(n - array[i]);
        }

        int min = Arrays.stream(minus).min().orElse(Integer.MAX_VALUE);

        int index = Arrays.stream(minus).boxed().collect(Collectors.toList()).indexOf(min);

        return array[index];
    }
}