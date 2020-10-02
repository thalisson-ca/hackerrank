import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
    //Separate the Numbers
	//https://www.hackerrank.com/challenges/separate-the-numbers/problem
	
    private static final String YES = "YES";
    private static final String NO = "NO";
    
    // Complete the separateNumbers function below.
    static void separateNumbers(String s) {
        if(s.length()==1 || s.startsWith("0")) {
            System.out.println(NO);
            return;
        }
        
        for(int i=1;i<=s.length()/2;i++) { //First Number never will have more then s.length/2 digits
            String subNumber = s.substring(0, i);
            BigInteger firstNumber = new BigInteger(subNumber);
            StringBuilder sequenceMaker = new StringBuilder(subNumber);
            BigInteger next = firstNumber;
            do{
                next = next.add(BigInteger.ONE);
                sequenceMaker.append(next);
            }while(sequenceMaker.length()<s.length());
            if(s.contentEquals(sequenceMaker)) {
                System.out.println(YES+" "+firstNumber);
                return;
            }
        }
        
        System.out.println(NO);

    }
    

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            separateNumbers(s);
        }

        scanner.close();
    }
}
