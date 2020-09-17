import java.util.*;


public class Solution {

	//Insertion Sort 2
	//https://www.hackerrank.com/challenges/insertionsort2/problem
    // Complete the insertionSort1 function below.
    static void insertionSort2(int n, int[] arr) {
    	if(n==1) {
    		print(n, arr); 
    		return;
    	}
    	
    	int pivotPosition = 1;
    	while(pivotPosition<n) {
    		int pivotValue = arr[pivotPosition];
    		int i = pivotPosition-1;
    		while(i>=0) {
    			if(pivotValue<arr[i]) {
    				arr[i+1] = arr[i];
    			}else {
    				arr[i+1] = pivotValue;
    				break;
    			}
    			i--;
    		}
    		if(i==-1) {
    			arr[0] = pivotValue;
    		}
    		print(n, arr); 
    		pivotPosition++;
    	}
    }
    
    static void print(int n, int[] arr) {
    	String p = "";
    	for(int i=0;i<n;i++) {
    		p+=arr[i]+" ";
    	}
    	System.out.println(p.trim());
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] arr = new int[n];

        String[] arrItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int arrItem = Integer.parseInt(arrItems[i]);
            arr[i] = arrItem;
        }

        insertionSort2(n, arr);

        scanner.close();
    }
}
