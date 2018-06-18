using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        // Complete this function
        int max = ar[0]; int cont=0;
        for(int i=0;i<n;i++){
            if(ar[i]==max){
                cont++;
            }else if(ar[i]>max){
                cont=1;
                max=ar[i];
            }
        }
        return cont;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
