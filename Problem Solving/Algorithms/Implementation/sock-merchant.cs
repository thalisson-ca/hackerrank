using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int sockMerchant(int n, int[] ar) {
        // Complete this function
        int count=0;
        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++){
                if(ar[i]==ar[j] && ar[j]!=-1){
                    count++;
                    ar[i]=-1;
                    ar[j]=-1;
                }
            }
        }
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}
