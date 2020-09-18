import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

	//The Grid Search
	//https://www.hackerrank.com/challenges/the-grid-search/problem
    // Complete the gridSearch function below.
    static String gridSearch(String[] G, String[] P) {
        
        int maxSearchX = G.length - P.length;
        int maxSearchY = G[0].length() - P[0].length(); 
      
        for(int i=0;i<=maxSearchX;i++) {
            for(int j=0;j<=maxSearchY;j++) {
                if(G[i].charAt(j)==P[0].charAt(0)) {
                    //Se entrou aqui, é um padrão em potencial
                    boolean allEquals = true;
                    for(int k=0;k<P.length;k++) {
                        String pattern = G[i+k].substring(j,j+P[k].length());
                        if(!pattern.equals(P[k])) {
                            allEquals = false;
                            break;
                        }
                    }
                    if(allEquals) {
                        return "YES";
                    }
                    
                }
                
            }
            
        }
        
        return "NO";
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int t = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int tItr = 0; tItr < t; tItr++) {
            String[] RC = scanner.nextLine().split(" ");

            int R = Integer.parseInt(RC[0]);

            int C = Integer.parseInt(RC[1]);

            String[] G = new String[R];

            for (int i = 0; i < R; i++) {
                String GItem = scanner.nextLine();
                G[i] = GItem;
            }

            String[] rc = scanner.nextLine().split(" ");

            int r = Integer.parseInt(rc[0]);

            int c = Integer.parseInt(rc[1]);

            String[] P = new String[r];

            for (int i = 0; i < r; i++) {
                String PItem = scanner.nextLine();
                P[i] = PItem;
            }

            String result = gridSearch(G, P);

            bufferedWriter.write(result);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
