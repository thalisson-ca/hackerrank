using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        
        int pos = 0;
        int e = 100;
        do{
            pos = (pos+k)%n;
            if(c[pos]==1){
                e-=3;
            }else{
                e--;
            }
        }while(pos!=0);
        Console.Write(e);
    }
}
