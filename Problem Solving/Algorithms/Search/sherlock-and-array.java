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

    //Sherlock and Array
	//https://www.hackerrank.com/challenges/sherlock-and-array/problem

    public static String balancedSums(List<Integer> arr) {
        int l = 0;
        int r = 0;
        int maxR = 1;
        int arrSize = arr.size();
        for(int i=0;i<arrSize;i++){
            int c = arr.get(i);
            while(l<=r && maxR<arrSize) {
            	r+=arr.get(maxR);
            	maxR++;
            }
        	
            if(l==r) {
            	return "YES";
            }
        	l+=c;
        	if(r>0) {
        		r-=arr.get(i+1);
        	}
            
        }
        return "NO";
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int T = Integer.parseInt(bufferedReader.readLine().trim());

        IntStream.range(0, T).forEach(TItr -> {
            try {
                int n = Integer.parseInt(bufferedReader.readLine().trim());

                List<Integer> arr = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
                    .map(Integer::parseInt)
                    .collect(toList());

                String result = Result.balancedSums(arr);

                bufferedWriter.write(result);
                bufferedWriter.newLine();
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        bufferedReader.close();
        bufferedWriter.close();
    }
}
