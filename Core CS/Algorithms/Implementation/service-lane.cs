using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int t = Convert.ToInt32(tokens_n[1]);
        string[] width_temp = Console.ReadLine().Split(' ');
        int[] width = Array.ConvertAll(width_temp,Int32.Parse);
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            
            int min = 3;
            for(int x=i;x<=j;x++){
                min = Math.Min(min,width[x]);
                if(min==1) break;
            }
            Console.WriteLine(min);
            
            
        }
    }
}
