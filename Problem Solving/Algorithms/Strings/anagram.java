import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Anagram
	//https://www.hackerrank.com/challenges/anagram/problem
    // Complete the anagram function below.
    static int anagram(char[] s) {
        int size = s.length/2;
        if(s.length%2==1) {
            return -1;
        }
        
        int[] table = new int[26];
        for(int i=0;i<s.length;i++) {
            if(i<size) {
                table[s[i]-'a']++;
            }else {
                table[s[i]-'a']--;
            }
        }
        
        int result = 0;
        for(int i=0;i<table.length;i++) {
            if(table[i]>0) {
                result+=table[i];
            }
        }
        
        return result;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            int result = anagram(s.toCharArray());

            bufferedWriter.write(String.valueOf(result));
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
