using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] array = Console.ReadLine().Split(' ');
        int n = int.Parse(array[0]);
        int d = int.Parse(array[1]);
        
        int[] seq = Array.ConvertAll( Console.ReadLine().Split(' '),int.Parse);
        
        int count =0;
        for(int i=0;i<seq.Length;i++){
            for(int j=i+1;j<seq.Length;j++){
                for(int k=j+1;k<seq.Length;k++){
                    if(seq[j]-seq[i]==d && seq[k]-seq[j]==d){
                        count++;
                    }else if(seq[j]-seq[i]>d || seq[k]-seq[j]>d){
                        break;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}