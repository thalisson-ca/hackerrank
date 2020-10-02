import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

	//Beautiful Binary String
	//https://www.hackerrank.com/challenges/beautiful-binary-string/problem
    // Complete the beautifulBinaryString function below.
    static int beautifulBinaryString(char[] b) {
    	int count = 0;
    	
    	for(int i=2;i<b.length;i++) {
    		if(b[i-2]=='0' && b[i-1]=='1' && b[i]=='0') {
    			count++;
    			i+=2;
    		}
    	}
    	
    	return count;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String b = scanner.nextLine();

        int result = beautifulBinaryString(b.toCharArray());

        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));
        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
