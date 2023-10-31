import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main {
    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String input = br.readLine();

        StringTokenizer stn = new StringTokenizer(input);

        int[] i = new int[] {Integer.parseInt(stn.nextToken()),
                Integer.parseInt(stn.nextToken()), Integer.parseInt(stn.nextToken())};

        System.out.println((i[0] + i[1]) % i[2]);
        System.out.println(((i[0] % i[2]) + (i[1] % i[2])) % i[2]);
        System.out.println((i[0] * i[1]) % i[2]);
        System.out.println(((i[0] % i[2]) * (i[1] % i[2])) % i[2]);
    }
}