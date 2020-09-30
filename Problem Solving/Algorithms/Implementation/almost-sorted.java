import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Almost Sorted
	//https://www.hackerrank.com/challenges/almost-sorted/problem
    // Complete the almostSorted function below.
    static void almostSorted(int[] arr) {
        int first = -1;
        int last = -1;
        int lastNegative = -1;
        int countNegative = 0;
        int countLess = 0;
        boolean negativeStreak = true;
        
        for(int i=0;i<arr.length-1;i++) {
            if(i<arr.length-1 && arr[i]>arr[i+1]) {
                if(first==-1) {
                    first = i;
                }
                if(lastNegative!=-1 && lastNegative!=i-1) {
                    negativeStreak = false;
                }
                lastNegative=i;
                countNegative++;
                last=i+1;
                
            }
            if(first!=-1 && arr[first]>arr[i+1]) {
                countLess++;
            }
            
        }
        for(int i=last-1;i>=0;i--) {
            if(arr[i]>arr[last]) {
                countLess--;
            }
        }
 
        if(first==-1) {
            showResult(true,false,first,last,true);
        }else if(negativeStreak && countNegative>2 && countLess==0){
            showResult(true,true,first,last,false);
        }else {
            if(countNegative<=2 && countLess==0 && arr[first]>arr[last]){
                showResult(true,false,first,last,false);
            }else {
                showResult(false,false,first,last,false);
            }
        }
    }

    static void showResult(boolean isPossible, Boolean isSequence,int indexBegin, int indexEnd,boolean alreadySorted) {
        if(isPossible) {
            System.out.println("yes");
            if(alreadySorted)return;
            if(isSequence) {
                System.out.println("reverse "+(indexBegin+1)+" "+(indexEnd+1));
            }else {
                System.out.println("swap "+(indexBegin+1)+" "+(indexEnd+1));
            }
        }else {
            System.out.println("no");
        }
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

        almostSorted(arr);

        scanner.close();
    }
}
