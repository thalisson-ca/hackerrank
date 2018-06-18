using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        
        int pDiagonal = 0;
        int sDiagonal = 0;
        int maxP = n-1;
        
        for(int i=0;i<n;i++){
            pDiagonal+= a[i][i];
            sDiagonal+= a[i][maxP-i];
        }
        
        Console.Write(Math.Abs(pDiagonal-sDiagonal));
        
    }
}
