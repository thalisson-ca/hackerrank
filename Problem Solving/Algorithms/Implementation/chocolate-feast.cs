using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int c = Convert.ToInt32(tokens_n[1]);
            int m = Convert.ToInt32(tokens_n[2]);
            
            int a = n/c;
            int total = a;
            
            do{
                int q = a/m;
                int r = a%m;
                total+=q;
                a=r+q;
                
            }while(a>=m);
           
          
            
            Console.WriteLine(total);
            
        }
    }
}
