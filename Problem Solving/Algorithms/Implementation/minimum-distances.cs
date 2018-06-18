using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] A = Array.ConvertAll(A_temp,Int32.Parse);
        
        Dictionary<int, int> posicao = new Dictionary<int,int>();
        int minDist = int.MaxValue;
        for(int i=0;i<n;i++){
            if(posicao.ContainsKey(A[i])){
                minDist = Math.Min(minDist,Math.Abs(i-posicao[A[i]]));
            }
             posicao[A[i]] = i;
        }
        
        if(minDist==int.MaxValue){
            Console.WriteLine("-1");
        }else{
            Console.WriteLine(minDist);
        }
        
    }
}
