import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the maximizingXor function below.
    static int maximizingXor(int l, int r) {
        //Get the XOR value from l and r
        int xorValue = l^r; 
        
        //Get the value of the most significant 1 digit from the value
        int mostSignificantBinaryDigit = Integer.highestOneBit(xorValue); 
        
        //The rule always be mapped with the formula m*2-1
        return mostSignificantBinaryDigit*2-1;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int l = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int r = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int result = maximizingXor(l, r);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
