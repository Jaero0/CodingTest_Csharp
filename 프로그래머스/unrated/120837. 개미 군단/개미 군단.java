class Solution {
    public int solution(int hp) {

        int general = 5;
        int soldier = 3;

        return hp / general + (hp%general)/soldier + ((hp%general)%soldier);
    }
}