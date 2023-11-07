import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main {
    public static void main(String[] args) throws Exception {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int totalSubjectsCount = Integer.parseInt(br.readLine());

        String scores = br.readLine();
        StringTokenizer stn = new StringTokenizer(scores);

        double max = 0;

        double totalScore = 0;

        for (int i = 0; i < totalSubjectsCount; i++) {

            int s = Integer.parseInt(stn.nextToken());

            if (max < s) {
                max = s;
            }

            totalScore += s;
        }

        System.out.println((totalScore / max * 100) / totalSubjectsCount);
    }
}
