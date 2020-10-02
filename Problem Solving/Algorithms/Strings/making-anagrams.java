import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Making Anagrams
	//https://www.hackerrank.com/challenges/making-anagrams/problem
    // Complete the makingAnagrams function below.
    static int makingAnagrams(char[] s1, char[] s2) {
    	
    	int[] table = new int[26];
    	for(int i=0;i<s1.length;i++) {
                table[s1[i]-'a']++;
            
        }
    	
    	for(int i=0;i<s2.length;i++) {
            table[s2[i]-'a']--;
        
    }
    	
    	
    	int result = 0;
        for(int i=0;i<table.length;i++) {
            result+=Math.abs(table[i]);
        }
        
        return result;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s1 = scanner.nextLine();

        String s2 = scanner.nextLine();

        int result = makingAnagrams(s1.toCharArray(), s2.toCharArray());

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
