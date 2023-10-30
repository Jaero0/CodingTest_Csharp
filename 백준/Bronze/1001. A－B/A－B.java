import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main {
    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String input = br.readLine();
        StringTokenizer stn = new StringTokenizer(input);

        int a = Integer.parseInt(stn.nextToken());
        int b = Integer.parseInt(stn.nextToken());

        System.out.println(a-b);
    }
}