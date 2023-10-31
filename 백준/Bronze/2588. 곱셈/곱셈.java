import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        
        int a = Integer.parseInt(br.readLine());

        String input = br.readLine();
        
        char c;

        for (int i = input.length()-1; i >=0 ; i--) {

            c = input.charAt(i);

            System.out.println(a * Integer.parseInt(String.valueOf(c)));
        }

        System.out.println(a * Integer.parseInt(input));
    }
}