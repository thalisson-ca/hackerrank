using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] M = new int[n][];
            for(int M_i = 0; M_i < n; M_i++){
               string[] M_temp = Console.ReadLine().Split(' ');
               M[M_i] = Array.ConvertAll(M_temp,Int32.Parse);
            }
            // your code goes here
            string result = "Possible";
            List<int> total_i = new List<int>();
            List<int> total_j = new List<int>();
            for(int i=0;i<n;i++){
                int sum_i = 0;
                int sum_j = 0;
                for(int j=0;j<n;j++){
                    sum_i+=M[i][j];
                    sum_j+=M[j][i];
                }
                total_i.Add(sum_i);
                total_j.Add(sum_j);
            }
            
            foreach(int valor in total_j){
                if(!total_i.Contains(valor)){
                    result = "Impossible";
                    break;
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
