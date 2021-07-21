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

    //Missing Numbers
	//https://www.hackerrank.com/challenges/missing-numbers/problem

    public static List<Integer> missingNumbers(List<Integer> arr, List<Integer> brr) {
    // Write your code here
        HashSet<Integer> r = new HashSet<Integer>();
    	HashMap<Integer,Integer> freq = new HashMap<Integer,Integer>();
        for(Integer i:arr) {
        	if(freq.containsKey(i)) {
        		Integer v = freq.get(i);
        		v--;
        		freq.put(i, v);
        		
        	}else {
        		freq.put(i, -1);
        	}
        }
        
        for(int i:brr) {
        	if(freq.containsKey(i)) {
        		Integer v = freq.get(i);
        		v++;
        		freq.put(i, v);
        		if(v>0) {
        			r.add(i);
        		}
        		
        	}else {
        		r.add(i);
        	}
        }
        
        ArrayList<Integer> result =new ArrayList<Integer>(r);
        result.sort(null);
        return result;
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = Integer.parseInt(bufferedReader.readLine().trim());

        List<Integer> arr = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        int m = Integer.parseInt(bufferedReader.readLine().trim());

        List<Integer> brr = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        List<Integer> result = Result.missingNumbers(arr, brr);

        bufferedWriter.write(
            result.stream()
                .map(Object::toString)
                .collect(joining(" "))
            + "\n"
        );

        bufferedReader.close();
        bufferedWriter.close();
    }
}
