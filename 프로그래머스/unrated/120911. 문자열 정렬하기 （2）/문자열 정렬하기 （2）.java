class Solution {
    public String solution(String my_string) {
        
        my_string = my_string.toLowerCase()
                .chars()        
                .sorted()
                .collect(StringBuilder::new,
                        StringBuilder::appendCodePoint,
                        StringBuilder::append)
                .toString();
        
        return my_string;
    }
}