import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Weighted Uniform Strings
	//https://www.hackerrank.com/challenges/weighted-uniform-string/problem
    // Complete the weightedUniformStrings function below.
    static String[] weightedUniformStrings(char[] s, int[] queries) {
        HashSet<Integer> values = new HashSet<Integer>();
        int repeat=0;
        for(int i=0;i<s.length;i++) {
            if(i>0 && s[i]==s[i-1]) {
                repeat++;
            }else {
                repeat=1;
            }
            values.add((1+s[i]-'a')*repeat);
        }
        
        String[] response = new String[queries.length];
        for(int i=0;i<queries.length;i++) {
            response[i] = values.contains(queries[i])?"Yes":"No";
        }
        
        return response;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        

        String s = scanner.nextLine();

        int queriesCount = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] queries = new int[queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            int queriesItem = scanner.nextInt();
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
            queries[i] = queriesItem;
        }

        String[] result = weightedUniformStrings(s.toCharArray(), queries);
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));
        for (int i = 0; i < result.length; i++) {
            bufferedWriter.write(result[i]);

            if (i != result.length - 1) {
                bufferedWriter.write("\n");
            }
        }

        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
