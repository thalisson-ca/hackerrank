import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    //Funny String
    //https://www.hackerrank.com/challenges/funny-string/problem
    // Complete the funnyString function below.
    static String funnyString(char[] s) {
        String result = "Funny";
        int l = s.length-1;
        for(int i=0;i<l;i++) {
            if(dif(s[i],s[i+1])!=dif(s[l-i],s[l-i-1])){
                result = "Not Funny";
            }
        }
        
        
        return result;
    }
    
    private static int dif(char c1, char c2) {
        return Math.abs(c2-c1);
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            String result = funnyString(s.toCharArray());

            bufferedWriter.write(result);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
