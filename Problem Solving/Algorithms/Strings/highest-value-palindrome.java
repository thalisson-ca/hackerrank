import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Highest Value Palindrome
	//https://www.hackerrank.com/challenges/richie-rich/problem
	

    static String highestValuePalindrome(char[] s, int n, int k) {
        boolean isOdd = n%2==1;
        int middle = (isOdd)?(n-1)/2:n/2;
        boolean[] changed = new boolean[middle];
        
        for(int i=0;i<middle;i++) {
            int o = n-i-1;
            if(s[i]!=s[o]) {
                int max = Math.max(s[i], s[o]);
                s[o] = (char)max;
                s[i] = (char)max;
                k--;
                changed[i]=true;
                if(k<0) {
                    return "-1";
                }
            }
        }
        
        for(int i=0;i<middle;i++) {
            if(s[i]!='9') {
                int o = n-i-1;
                if((k>=1)&&(changed[i] || k>=2)) {
                    s[i] = '9';
                    s[o] = '9';
                    if(changed[i]) {
                        k--;
                    }else {
                        k-=2;
                    }
                }
                
            }
        }
        
        if(isOdd && s[middle]!='9' && k>=1) {
            s[middle]='9';
        }
        
        return new String(s);
    }


    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nk = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nk[0]);

        int k = Integer.parseInt(nk[1]);
        
        String s = scanner.nextLine();

        String result = highestValuePalindrome(s.toCharArray(), n, k);
       
        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
