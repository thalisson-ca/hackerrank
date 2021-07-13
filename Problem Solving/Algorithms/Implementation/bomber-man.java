import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//The Bomberman Game
	//https://www.hackerrank.com/challenges/bomber-man/problem
    // Complete the bomberMan function below.
    static char[][] bomberMan(int n, char[][] grid) {

    	if(n==1) {
    		return grid;
    	}
    	if(n==2) {
    		return full(grid);
    		
    	}
    	
    	switch(((n-3)%4)) {
    		case 0:
    			return state1(grid);
    		case 1:
    		case 3:
    			return full(grid);
    		case 2:
    			return state2(grid);
    	}
    	return null;

    }

	private static char[][] state2(char[][] grid) {
			
		return state1(state1(grid));
	}

	private static char[][] state1(char[][] grid) {
		char[][] result = new char[grid.length][grid[0].length];
		for(int i=0;i<grid.length;i++) {
			for(int j=0;j<grid[i].length;j++) {
				if((i>0 && grid[i-1][j]=='O') ||
				   (i<grid.length-1 && grid[i+1][j]=='O') ||
				   (j>0 && grid[i][j-1]=='O') ||
				   (j<grid[i].length-1 && grid[i][j+1]=='O') ||
				   grid[i][j]=='O') {
					result[i][j]='.';
				}else {
					result[i][j]='O';
				}
			}
		}
		return result;
	}

	private static char[][] full(char[][] grid) {
		for(int i=0;i<grid.length;i++) {
			for(int j=0;j<grid[i].length;j++) {
				grid[i][j] = 'O';
			}
		}
		return grid;
	}

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] rcn = scanner.nextLine().split(" ");

        int r = Integer.parseInt(rcn[0]);

        int c = Integer.parseInt(rcn[1]);

        int n = Integer.parseInt(rcn[2]);

        char[][] grid = new char[r][c];

        for (int i = 0; i < r; i++) {
            String gridItem = scanner.nextLine();
            grid[i] = gridItem.toCharArray();  
        }

        char[][] result = bomberMan(n, grid);

        for (int i = 0; i < result.length; i++) {
            bufferedWriter.write(result[i]);

            if (i != result.length - 1) {
                bufferedWriter.write("\n");
            }
        }

        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
