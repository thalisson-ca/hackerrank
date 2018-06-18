using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        Int64[] arr = Array.ConvertAll(arr_temp,Int64.Parse);
        Int64 sum=0, max = arr[0] , min= arr[0];
        for(int i=0;i<5;i++){
            sum+=arr[i];
            if(arr[i]>max){
                max=arr[i];   
            }else if(arr[i]<min){
                min=arr[i];
            }
        }
        Console.Write((sum-max)+" "+(sum-min));
        
    }
}
