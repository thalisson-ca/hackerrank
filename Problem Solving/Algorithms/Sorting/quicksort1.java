import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

	//Quicksort 1 - Partition
	//https://www.hackerrank.com/challenges/quicksort1/problem
    // Complete the quickSort function below.
    static int[] quickSort(int[] arr) {
        int pivot = arr[0];
        ArrayList<Integer> left = new ArrayList<Integer>();
        ArrayList<Integer> right = new ArrayList<Integer>();
        ArrayList<Integer> equals = new ArrayList<Integer>();
        
        for(int i=0;i<arr.length;i++) {
            if(arr[i]<pivot) {
                left.add(arr[i]);
            }else if(arr[i]>pivot) {
                right.add(arr[i]);
            }else {
                equals.add(arr[i]);
            }
        }
        
        
        left.addAll(equals);
        left.addAll(right);
        for(int i=0;i<arr.length;i++) {
            arr[i] = left.get(i);
        }
        
        return arr;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] arr = new int[n];

        String[] arrItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int arrItem = Integer.parseInt(arrItems[i]);
            arr[i] = arrItem;
        }

        int[] result = quickSort(arr);

        for (int i = 0; i < result.length; i++) {
            bufferedWriter.write(String.valueOf(result[i]));

            if (i != result.length - 1) {
                bufferedWriter.write(" ");
            }
        }

        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
