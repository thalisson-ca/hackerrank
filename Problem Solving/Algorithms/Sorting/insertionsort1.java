import java.util.*;


public class Solution {
	//Problem: Insert Sort 1
	//https://www.hackerrank.com/challenges/insertionsort1/problem

    // Complete the insertionSort1 function below.
    static void insertionSort1(int n, int[] arr) {
    	int pivot = arr[n-1];
    	int i = n-2;
    	while(i>=0) {
    		if(pivot<arr[i]) {
    			arr[i+1] = arr[i];
    			print(n,arr);
    		}else {
    			arr[i+1] = pivot;
    			print(n,arr);
    			break;
    		}
    		i--;
    	}
    	if(i==-1) {
    		arr[0] = pivot;
    		print(n,arr);
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

        insertionSort1(n, arr);

        scanner.close();
    }
}
