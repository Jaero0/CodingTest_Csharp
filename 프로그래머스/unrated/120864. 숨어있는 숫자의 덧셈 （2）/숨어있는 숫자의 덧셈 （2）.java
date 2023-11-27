import java.util.StringTokenizer;

class Solution {
    public int solution(String my_string) {

        int answer = 0;

        my_string = my_string.replaceAll("[^\\d]+", " ");

        StringTokenizer stn = new StringTokenizer(my_string);
        while (stn.hasMoreTokens()) {

            answer += Integer.parseInt(stn.nextToken());
        }
        return answer;
}
}