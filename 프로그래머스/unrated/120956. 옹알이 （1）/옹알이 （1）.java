class Solution {
    public static int solution(String[] babbling) {
        int answer = 0;

        String[] aya = {"aya", "ye", "woo", "ma"};

        for (int i = 0; i < babbling.length; i++) {

            String s = babbling[i];

            for (int j = 0; j < aya.length; j++) {

                if (babbling[i].contains(aya[j])) {
                    s = s.replace(aya[j], " ");
                }
            }

            babbling[i] = s;

            if (babbling[i] != null) {
                String s2 = babbling[i].trim();
                if (s2.equals("")) {
                    answer++;
                }
            }
        }

        return answer;
    }
}