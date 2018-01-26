using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long[] array;
    static long max;
    
    static void operations(long a, long b, long k){
        array[a]+=k;
        if(b<array.Length-1){
            array[b+1]-=k;
        }
        
    }
    
    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        long n = Convert.ToInt32(tokens_n[0]);
        long m = Convert.ToInt32(tokens_n[1]);
        
        array = new long[n+1];
        max = long.MinValue;
        
        for(int a0 = 0; a0 < m; a0++){
            string[] tokens_a = Console.ReadLine().Split(' ');
            long a = Convert.ToInt32(tokens_a[0])-1;
            long b = Convert.ToInt32(tokens_a[1])-1;
            long k = Convert.ToInt32(tokens_a[2]);
            operations(a, b, k);
        }
        
        long l=0;
        for(long i=0;i<array.Length;i++){
            l+=array[i]; 
            if(l>max){
                max=l;
            }
        }
        Console.WriteLine(max);
    }
}
