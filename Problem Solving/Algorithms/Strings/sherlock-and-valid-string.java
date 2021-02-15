import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Sherlock and the Valid String
	//https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
    // Complete the isValid function below.
    static String isValid(char[] s) {
    	
    	if(s.length<=3) {
    		return "YES";
    	}
    	
    	int[] alphaFreq = new int[26];
    	for(int i=0;i<s.length;i++) {
    		alphaFreq[s[i]-'a']++;
    	}
    	Arrays.sort(alphaFreq);
    	
    	int begin = 0;
    	while(alphaFreq[begin]==0){
    		begin++;
        }
    	
    	int maxFreq = alphaFreq[25];
    	int minFreq = alphaFreq[begin];
 	return (maxFreq==minFreq || 
    		   (maxFreq-minFreq==1 && maxFreq>alphaFreq[24]) || 
    		   (maxFreq==alphaFreq[begin+1] && minFreq==1))?"YES":"NO";
    	
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        String result = isValid(s.toCharArray());

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
