import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Game of Thrones - I
	//https://www.hackerrank.com/challenges/game-of-thrones/problem
    // Complete the gameOfThrones function below.
    static String gameOfThrones(char[] s) {
        int[] table = new int[26];
        for(int i=0;i<s.length;i++) {
                table[s[i]-'a']++;
        }
        
        int qtdOdd = 0;
        int maxOdd = 0;
        for(int i=0;i<table.length;i++) {
            if(table[i]%2==1) {
                qtdOdd++;
                if(table[i]>maxOdd) {
                    maxOdd=table[i];
                }
            }
        }
        
        boolean sIsEven = (s.length%2==0);
        return ((sIsEven && qtdOdd==0)||(!sIsEven && qtdOdd==1))?"YES":"NO";

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        String result = gameOfThrones(s.toCharArray());

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
