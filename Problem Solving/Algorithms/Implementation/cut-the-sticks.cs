using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int min = int.MaxValue;
        for(int i=0;i<n;i++){
            min = Math.Min(min,arr[i]);
        }
        
        int total = n;
        do{
            Console.WriteLine(total);
            int desc = min;
            min = int.MaxValue;
            for(int i=0;i<n;i++){
                arr[i]-=desc;
                if(arr[i]>0){
                    min = Math.Min(min,arr[i]);
                }else if(arr[i]==0){
                    total--;
                }
            }
            
        }while(total>0);
        
    }
}
