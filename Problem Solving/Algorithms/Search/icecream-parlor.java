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

	//Ice Cream Parlor
	//https://www.hackerrank.com/challenges/icecream-parlor/problem
    public static List<Integer> icecreamParlor(int m, List<Integer> arr) {
    // Write your code here
        HashMap<Integer,Integer> hash = new HashMap<Integer,Integer>();
        List<Integer> result = new ArrayList<Integer>();
        for(int i=0;i<arr.size();i++) {
        	Integer price = arr.get(i);
        	Integer complement = m-price;
        	if(hash.containsKey(complement)) {
        			result.add(hash.get(complement)+1);
        			result.add(i+1);
        		   		
        	}else {
        		hash.put(price, i);
        	}
        }
        
        return result;

    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int t = Integer.parseInt(bufferedReader.readLine().trim());

        IntStream.range(0, t).forEach(tItr -> {
            try {
                int m = Integer.parseInt(bufferedReader.readLine().trim());

                int n = Integer.parseInt(bufferedReader.readLine().trim());

                List<Integer> arr = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
                    .map(Integer::parseInt)
                    .collect(toList());

                List<Integer> result = Result.icecreamParlor(m, arr);

                bufferedWriter.write(
                    result.stream()
                        .map(Object::toString)
                        .collect(joining(" "))
                    + "\n"
                );
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        bufferedReader.close();
        bufferedWriter.close();
    }
}
