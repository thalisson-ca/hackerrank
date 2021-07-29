import java.io.*;
import java.util.*;
import java.util.stream.*;
import static java.util.stream.Collectors.toList;

class Result {
	//Grid Challenge
    //https://www.hackerrank.com/challenges/grid-challenge/problem

    public static String gridChallenge(List<char[]> grid) {
       
    	char[][] realGrid = new char[grid.size()][grid.size()];
    	//1. Order lines
    	int i=0;
    	for(char[] line : grid) {
    		Arrays.sort(line);
    		realGrid[i] = line;
    		i++;
    	}
    	
    	for(i=0;i<realGrid.length;i++) {
    		char currentMax = 'a';
    		for(int j=0;j<realGrid.length;j++) {
    			if(realGrid[j][i]<currentMax) {
    				return "NO";
    			}
    			
    			currentMax = realGrid[j][i]; 
    			
    		}
    	}
    	
    	return "YES";
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int t = Integer.parseInt(bufferedReader.readLine().trim());

        IntStream.range(0, t).forEach(tItr -> {
            try {
                int n = Integer.parseInt(bufferedReader.readLine().trim());

                List<char[]> grid = IntStream.range(0, n).mapToObj(i -> {
                    try {
                        return bufferedReader.readLine().toCharArray();
                    } catch (IOException ex) {
                        throw new RuntimeException(ex);
                    }
                }).collect(toList());

                String result = Result.gridChallenge(grid);

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
