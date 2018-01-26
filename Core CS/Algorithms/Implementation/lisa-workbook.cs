using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] b1 = Console.ReadLine().Split(' ');
        int n = int.Parse(b1[0]);
        int k = int.Parse(b1[1]);
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
        
        int count = 0;
        int pagAtual = 0;
        for(int i=0;i<n;i++){
            if(pagAtual<a[i]){
                for(int x=1;x<=a[i];x++){
                    if(x==pagAtual+Math.Ceiling((decimal)x/k)){
                        count++;
                    }
                }
            }
            pagAtual+=(int)Math.Ceiling((decimal)a[i]/k);
        }
        Console.WriteLine(count);
    }
}