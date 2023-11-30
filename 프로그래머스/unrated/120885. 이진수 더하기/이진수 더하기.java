class Solution {
    public String solution(String bin1, String bin2) {
        StringBuilder sb = new StringBuilder();
        
        bin1 = reverseString(bin1);
        bin2 = reverseString(bin2);
        
        char[] bin1Chars = bin1.toCharArray();
        char[] bin2Chars = bin2.toCharArray();

        int sum = binaryNumToDecimalNum(bin1Chars) + binaryNumToDecimalNum(bin2Chars);
        System.out.println(binaryNumToDecimalNum(bin1Chars));
        System.out.println(binaryNumToDecimalNum(bin2Chars));

        System.out.println(sum);

        while (sum > 0) {

            sb.append(sum % 2);
            sum /= 2;
        }

        return sb.length() == 0 ? "0" : sb.reverse().toString();
    }

    public int binaryNumToDecimalNum(char[] chars) {

        int decimalNum = 0;

        for (int i = 0; i < chars.length; i++) {

            if (chars[i] == '1') {

                decimalNum += (int)Math.pow(2, i);
            }
        }

        return decimalNum;
    }
    
    public String reverseString(String s) {
        StringBuilder sb = new StringBuilder();

        sb.append(s);
        s = sb.reverse().toString();
        sb.delete(0, sb.length());
        
        return s;
    }
}