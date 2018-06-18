using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] B_temp = Console.ReadLine().Split(' ');
        int[] B = Array.ConvertAll(B_temp,Int32.Parse);
        
        int cont = 0;
        for(int i=0;i<N-1;i++){
            if(B[i]%2==1){
                B[i]++;
                B[i+1]++;
                cont+=2;
            }
        }
        
        Console.Write((B[N-1]%2==0)?cont+"":"NO");
    }
}
