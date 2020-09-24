import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Absolute Permutation
	//https://www.hackerrank.com/challenges/absolute-permutation/problem
    // Complete the absolutePermutation function below.
    static int[] absolutePermutation(int n, int k) {

        if(k==0) {
            int[] r = new int[n];
            for(int i=1;i<=n;i++) {
                r[i-1]= i;
                
            }
            return r;
        }
        if(n%k!=0 || (n/k)%2!=0){
            int[] r = {-1};
            return r;
        }
        int[] r = new int[n];
        for(int i=1;i<=n;i++) {
            if(r[i-1]==0) {
                r[i-1] = i+k;
                r[i+k-1] = i;
            }
        }
        return r;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int t = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int tItr = 0; tItr < t; tItr++) {
            String[] nk = scanner.nextLine().split(" ");

            int n = Integer.parseInt(nk[0]);

            int k = Integer.parseInt(nk[1]);

            int[] result = absolutePermutation(n, k);

            for (int i = 0; i < result.length; i++) {
                bufferedWriter.write(String.valueOf(result[i]));

                if (i != result.length - 1) {
                    bufferedWriter.write(" ");
                }
            }

            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
