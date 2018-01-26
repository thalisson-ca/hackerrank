using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        // Complete this function
        int[] qtd = new int[]{0,0,0,0,0};
        for(int i=0;i<n;i++){
            qtd[ar[i]-1]++;
        }
        int max = qtd[0];
        int tipo = 1;
        for(int i=1;i<5;i++){
            if(qtd[i]>max){
                tipo=i+1;
                max=qtd[i];
            }
        }
        return tipo;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
