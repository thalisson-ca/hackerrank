import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Palindrome Index
	//https://www.hackerrank.com/challenges/palindrome-index/problem
    // Complete the palindromeIndex function below.
    static int palindromeIndex(char[] s) {
    	int index = -1;
    	int middle = s.length/2;
    	int last = s.length-1;
    	int left = 0;
    	int right = 0;
    	boolean switchPossibility = false;
    	for(int i=0;i<middle;i++) {
    		if(s[i+left]!=s[last-i-right]) {
    			if(index!=-1) {
    				if(switchPossibility) {
    					return -1;
    				}else {
    					switchPossibility = true; //Try the other possibility
    					if(left==1) {
    						i=index;
    						index = last-i;
    						left=0;
    						right=1;
    					}else {
    						i = last-index;
    						index = i;
    						left=1;
    						right=0;
    						
    					}
    				}
    			}else {
    				if(s[i+1]==s[last-i]) {
    					index = i;
    					left=1;
    					
    				}else if(s[i]==s[last-i-1]){
    					index = last-i;
    					right=1;
    					
    				}else {
    					return -1;
    				}
    				
    			}
    		}
    	}

    	return index;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            int result = palindromeIndex(s.toCharArray());
            
            bufferedWriter.write(String.valueOf(result));
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
