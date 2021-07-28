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

	//Minimum Absolute Difference in an Array
    //https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
	private static int findPlace(List<Integer> orderedList, int value, int start, int end) {
		int mid = (start+end)/2;
		
		int pM = orderedList.get(mid);
		int pS = orderedList.get(start);		
		int pE = orderedList.get(end);
				
		if(value<=pS) {
			orderedList.add(start, value);
			return start;
		}else if(value>=pE) {
			orderedList.add(value);
			return end+1;
		}else if((end-start)==1) {
			orderedList.add(end, value);
			return end;
		}else if(pS<value && value<pM) {
			return findPlace(orderedList,value,start,mid);
		}else {
			return findPlace(orderedList,value,mid,end);
		}
		
	}
	
    public static int minimumAbsoluteDifference(List<Integer> arr) {
    	 
    	ArrayList<Integer> order = new ArrayList<Integer>();
    	
    	int v1 = arr.remove(0);
    	int v2 = arr.remove(0);
    	
    	int mad = Math.abs(v1-v2);
    	
    	if(v1>v2) {
    		order.add(v2);
    		order.add(v1);
    	}else {
    		order.add(v1);
    		order.add(v2);
    	}
    	
    	while(!arr.isEmpty()) {
    		int current = arr.remove(0);
    		
    		int p = findPlace(order, current, 0, order.size()-1);
    		
    		if(p>0) {
    			mad = Math.min(Math.abs(current - order.get(p-1)), mad);
    			
    		}
    		if(p<order.size()-1) {
    			mad = Math.min(Math.abs(current - order.get(p+1)), mad);
    		}
    		
    		if(mad==0) {
    			return mad;
    		}
    	}
    	return mad;

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

        int result = Result.minimumAbsoluteDifference(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
