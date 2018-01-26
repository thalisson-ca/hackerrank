using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int divisibleSumPairs(int n, int k, int[] ar) {
        // Complete this function
        int count = 0;
        for(int j=1;j<n;j++){
            for(int i=0;i<j;i++){
                if((ar[i]+ar[j])%k==0){
                    count++;
                }
            }
        }
        return count;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}
