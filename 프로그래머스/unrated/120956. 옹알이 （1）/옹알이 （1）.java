class Solution {
    public int solution(String[] babbling) {
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
        }

        for (int i = 0; i < babbling.length; i++) {

            if (babbling[i] != null) {
                String s = babbling[i].trim();
                if (s.equals("")) {
                    answer++;
                }
            }
        }

        return answer;
    }
}