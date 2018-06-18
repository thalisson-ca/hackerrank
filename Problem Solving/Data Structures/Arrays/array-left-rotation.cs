using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] leftRotation(int[] a, int d, int n) {
        // Complete this function
        
        int[] aux = new int[n];
        
        for(int i=0;i<n;i++){
           aux[(i+(n-d))%n]=a[i];
        }
        return aux;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int d = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int[] result = leftRotation(a, d,n);
        Console.WriteLine(String.Join(" ", result));


    }
}
