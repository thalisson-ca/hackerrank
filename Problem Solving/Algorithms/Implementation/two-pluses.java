import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Ema's Supercomputer
	//https://www.hackerrank.com/challenges/two-pluses/problem
	
	public static class Plus{
		int posX;
		int posY;
		int maxTam;
		
		public Plus(int i, int j, char[][] grid) {
			posX = j;
			posY = i;
			maxTam=0;
			
			while(
					(i>maxTam && grid[i-(maxTam+1)][j]=='G') &&
					(i<(grid.length-(maxTam+1)) && grid[i+(maxTam+1)][j]=='G') &&
					(j>maxTam && grid[i][j-(maxTam+1)]=='G') &&
					(j<(grid[i].length-(maxTam+1)) && grid[i][j+(maxTam+1)]=='G')
					) {
				maxTam++;
			}
			
		}
		
		public int calculate(Plus other) {
			
			int difX = Math.abs(this.posX-other.posX);
			int difY = Math.abs(this.posY-other.posY);
		
			if(difX==0) {
				if(hasCollisionAlign(other, difY)) {
					return calculateAlignedPlus(other, difY);
					
				}
			}else if(difY==0) {
				if(hasCollisionAlign(other, difX)) {
					return calculateAlignedPlus(other, difX);
				}	
	
			}else {
				if(hasCollisionNotAlign(other,difX,difY)) {
					int maxAllowedSize = Math.max(difX,difY)-1;
					return area(Math.min(maxAllowedSize, this.maxTam))*area(Math.min(maxAllowedSize, other.maxTam));
					
				}
			
			}
			return area(this.maxTam)*area(other.maxTam);
		}

		private int calculateAlignedPlus(Plus other, int dif) {
			int mean = (dif-1)/2;
			if(this.maxTam<=mean || other.maxTam<=mean) {
				int minTam = Math.min(this.maxTam, other.maxTam);
				int maxTam = (dif-1)-minTam;
				return area(minTam)*maxTam;
			}else {
				int maxTam = (dif-1)-mean;
				return area(mean)*area(maxTam);
			}
		}
		
		public boolean hasCollisionAlign(Plus other, int d) {
			return (other.maxTam+this.maxTam)>=d;
		}
		
		public boolean hasCollisionNotAlign(Plus other, int difX,int difY) {
			return (this.maxTam>=difX && other.maxTam>=difY)||(this.maxTam>=difY && other.maxTam>=difX);
		}
		
		public int area(int t) {
			return 4*t+1;
		}
		
	}
	
    // Complete the twoPluses function below.
    static int twoPluses(char[][] grid) {
    	//Find all Pluses
    	ArrayList<Plus> list = new ArrayList<Plus>();
    	for(int i=0;i<grid.length;i++) {
    		for(int j=0;j<grid[i].length;j++) {
    			if(grid[i][j]=='G') {
    				Plus newPlus = new Plus(i,j,grid);
    				list.add(newPlus);
    			}
    		}
    	}
    	
    	//Compare product between pluses
    	int firstHigh = 0;
     	for(int i=0;i<list.size();i++) {
    		Plus head = list.get(i);
    		for(int j=i+1;j<list.size();j++) {
    			Plus other = list.get(j);
    			int value = head.calculate(other);
    			if(firstHigh<value) {
     				firstHigh = value;
    			}
    		}
    	}
    	
        return firstHigh;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        

        String[] nm = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nm[0]);

        int m = Integer.parseInt(nm[1]);

        char[][] grid = new char[n][m];

        for (int i = 0; i < n; i++) {
            String gridItem = scanner.nextLine();
            grid[i] = gridItem.toCharArray();
        }

        int result = twoPluses(grid);
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));
        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
