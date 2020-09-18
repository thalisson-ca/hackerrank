import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

	// Two Characters
	// https://www.hackerrank.com/challenges/two-characters/problem
    // Complete the alternate function below.
    static int alternate(String s) {

        if(s.length()==1) {
            return 0;
        }
                
        char[][] charMap = new char[26][26];
        int[][] stringCount = new int[26][26];
        
        for(char c: s.toCharArray()) {
            
            for(int i=0;i<26;i++) {
                if(charMap[i][c-'a']!=c && stringCount[i][c-'a']!=-1) {
                    charMap[i][c-'a']=c;
                    charMap[c-'a'][i]=c;
                    stringCount[i][c-'a']++;
                    stringCount[c-'a'][i]++;
                }else {
                    stringCount[i][c-'a']=-1;
                    stringCount[c-'a'][i]=-1;
                }
            }
        }
        
        int max = 0;
        for(int i=0;i<26;i++) {
            for(int j=i+1;j<26;j++) {
                if(stringCount[i][j]>max) {
                    max =stringCount[i][j]; 
                }
            }
        }
        
        
        return max;


    }

    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int l = Integer.parseInt(bufferedReader.readLine().trim());

        String s = bufferedReader.readLine();

        int result = alternate(s);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
