using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        
        if(n==m){
            Console.WriteLine(0);
        }else{
            bool[] map = new bool[n]; 
            for(int x=0;x<m;x++){
                map[c[x]]=true;
            }
            int count = 0;
            int max=0;
            bool isExtreme = false;
            for(int x=0;x<n;x++){
                if((x==0 || x==n-1) && !map[x]){
                    isExtreme=true;
                }
           
                if(map[x]==true || x==n-1){
                   if(x==n-1 && !map[x]) count++;
                   max = (isExtreme)?Math.Max(max,count) : Math.Max(max,(int)Math.Ceiling((double)count/2));
                   count=0;
                    isExtreme = false;
                }else{
                    count++;
                }
            }
            Console.WriteLine(max);
            
        }
        
    }
}
