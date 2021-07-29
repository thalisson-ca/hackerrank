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

    //Luck Balance
	//https://www.hackerrank.com/challenges/luck-balance/problem
	public static int luckBalance(int k, List<List<Integer>> contests) {
    	
    	int sumLuck = 0;
    	
    	ArrayList<Integer> importantOnes = new ArrayList<Integer>();
    	
    	for(List<Integer> contest:contests) {
    		int luck = contest.remove(0);
    		int important = contest.remove(0);
    		
    		sumLuck+= luck;
    		if(important!=0) {
    			int p = 0;
    			for(Integer lc : importantOnes) {
    				if(luck<lc) {
    					break;
    				}
    				p++;
    			}
    			importantOnes.add(p, luck);
    		}
    	}
    	
    	int needWin = importantOnes.size() - k;
    	
    	for(int w=0;w<needWin;w++) {
    		int luck = importantOnes.remove(0);
    		sumLuck -= 2*luck;
    		
    	}
    	
    	
    	return sumLuck;
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] firstMultipleInput = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        int n = Integer.parseInt(firstMultipleInput[0]);

        int k = Integer.parseInt(firstMultipleInput[1]);

        List<List<Integer>> contests = new ArrayList<>();

        IntStream.range(0, n).forEach(i -> {
            try {
                contests.add(
                    Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
                        .map(Integer::parseInt)
                        .collect(toList())
                );
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        int result = Result.luckBalance(k, contests);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
