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

    //Maximum Perimeter Triangle
	//https://www.hackerrank.com/challenges/maximum-perimeter-triangle/problem

    public static List<Integer> maximumPerimeterTriangle(List<Integer> sticks) {
    	sticks.sort(Comparator.reverseOrder());
    	List<Integer> r = new ArrayList<Integer>();
    	
    	for(int i=0;i<sticks.size()-2;i++) {
    		int a = sticks.get(i);
    		int b = sticks.get(i+1);
    		int c = sticks.get(i+2);
    		
    		if(a<b+c && b<a+c && c<a+b) {
    			r.add(c);
    			r.add(b);
    			r.add(a);
    			return r;
    		}
    		
    	}
    	
    	r.add(-1);
    	return r;

    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = Integer.parseInt(bufferedReader.readLine().trim());

        List<Integer> sticks = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        List<Integer> result = Result.maximumPerimeterTriangle(sticks);

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
