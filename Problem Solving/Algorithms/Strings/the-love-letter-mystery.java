import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//The Love-Letter Mystery
	//https://www.hackerrank.com/challenges/the-love-letter-mystery/problem
    // Complete the theLoveLetterMystery function below.
    static int theLoveLetterMystery(char[] s) {
        int count = 0;
        int middle = s.length/2;
        int last = s.length-1;
        for(int i=0;i<middle;i++) {
            count += Math.abs(s[i]-s[last-i]);
        }
        
        return count;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            int result = theLoveLetterMystery(s.toCharArray());

            bufferedWriter.write(String.valueOf(result));
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
