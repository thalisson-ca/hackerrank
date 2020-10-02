import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

	//Gemstones
	//https://www.hackerrank.com/challenges/gem-stones/problem
    // Complete the gemstones function below.
    static int gemstones(String[] arr) {
        HashSet<Character> result = stringToHashSet(arr[0]);
        for(int i=1;i<arr.length;i++) {
            result.retainAll(stringToHashSet(arr[i]));
        }
        
        return result.size();
    }
    
    private static HashSet<Character> stringToHashSet(String s){
        HashSet<Character> hash = new HashSet<Character>();
        for(int i=0;i<s.length();i++) {
            hash.add(s.charAt(i));
        }
        return hash;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String[] arr = new String[n];

        for (int i = 0; i < n; i++) {
            String arrItem = scanner.nextLine();
            arr[i] = arrItem;
        }

        int result = gemstones(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
