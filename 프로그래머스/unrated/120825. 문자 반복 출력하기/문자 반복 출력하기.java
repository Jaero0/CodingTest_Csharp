class Solution {
    public String solution(String my_string, int n) {

        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();

        long time1 = System.nanoTime();
        for (char c : my_string.toCharArray()) {

            for (int i = 0; i < n; i++) {

                sb.append(c);
            }
        }
        long ftime1 = System.nanoTime();
        System.out.println(ftime1-time1);


        long time2 = System.nanoTime();
        for (char c : my_string.toCharArray()) {

sb2.append((c + "").repeat((n)));
        }
        long ftime2 = System.nanoTime();
        System.out.println(ftime2-time2);

        return sb.toString();
    }
}