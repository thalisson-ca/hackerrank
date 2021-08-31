import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

class Result {

    //Sherlock and The Beast
	//https://www.hackerrank.com/challenges/sherlock-and-the-beast/problem

    public static void decentNumber(int n) {
        
        for(int A=n;A>=0;A--) {
            int midB = (n-3*A);
            boolean isAMatch = ((midB%5)==0)&& midB>=0;
            if(isAMatch) {
                int B = midB/5;
                StringBuilder sb = new StringBuilder();
                
                int n5 = 3*A;
                for(int i=0;i<n5;i++) {
                    sb.append("5");
                }
                
                int n3 = 5*B;
                for(int i=0;i<n3;i++) {
                    sb.append("3");
                }
                
                System.out.println(sb.toString());
                return;
            }

        }
        System.out.println("-1");

        
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        int t = Integer.parseInt(bufferedReader.readLine().trim());

        IntStream.range(0, t).forEach(tItr -> {
            try {
                int n = Integer.parseInt(bufferedReader.readLine().trim());

                Result.decentNumber(n);
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        bufferedReader.close();
    }
}
