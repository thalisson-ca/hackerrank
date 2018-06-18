using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        string[] a = Console.ReadLine().Split(' ');
        
        Dictionary<string,int> dic = new Dictionary<string,int>();
        
        for(int i=0;i<n;i++){
            if(!dic.ContainsKey(a[i])){
                dic[a[i]]=0;
            }
           dic[a[i]]++;
            
        }
        
        int biggest = 0;
        foreach(KeyValuePair<string, int> entry in dic){
            if(biggest<entry.Value){
                biggest=entry.Value;
            }    
        }
        
        Console.WriteLine(a.Length-biggest);
        
    }
}