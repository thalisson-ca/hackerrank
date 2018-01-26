using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getTotalX(int[] a, int[] b,int n, int m) {
        int maxA = a[0];
        int minB = b[0];
        
        for(int index = 1;index<n;index++){
            if(maxA<a[index]){
                maxA=a[index];
            }
        }
        
        for(int index = 1;index<m;index++){
            if(minB>b[index]){
                minB=b[index];
            }
        }
        
        int count = 0;
        for(int x=maxA;x<=minB;x++){
            bool isOk = true;
            for(int i=0;i<n;i++){
                if(x%a[i]!=0){
                    isOk=false;
                    break;
                }
            }
            if(isOk){
                for(int i=0;i<m;i++){
                    if(b[i]%x!=0){
                        isOk=false;
                        break;
                    }
                }
                if(isOk){
                    count++;
                }
            }
            
        }
        return count;
        
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b,n,m);
        Console.WriteLine(total);
    }
}
