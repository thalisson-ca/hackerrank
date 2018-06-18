using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        long p = long.Parse(Console.ReadLine());
        long q = long.Parse(Console.ReadLine());
        
        string result = "";
        for(long n = p; n<=q;n++){
            string n_2 = (n*n).ToString();
            int d = n.ToString().Length;
            long r = int.Parse(n_2.Substring(Math.Max(n_2.Length-d,0)));
            long l = 0;
            if(d!=n_2.Length){
                l = int.Parse(n_2.Substring(0,n_2.Length-d));
            }
            
            
            if(l+r==n){
                result+=n+" ";
            }
            
        }
        result+=(result=="")?"INVALID RANGE":"";
        Console.Write(result);
        
    }
}