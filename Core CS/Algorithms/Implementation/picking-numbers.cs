using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        int resp = 2;
        for(int i=0;i<n;i++){
            int contMAIS = 0;
            int contMENOS = 0;
            for(int j=0;j<n;j++){
                int dif = a[i]-a[j];
                if(dif==1 || dif==0){
                    contMAIS++;
                }
                
                if(dif==-1 || dif==0){
                    contMENOS++;
                }
            }
            if(contMAIS>resp){
                resp=contMAIS;
            }
            if(contMENOS>resp){
                resp=contMENOS;
            }
        }
        Console.WriteLine(resp);
    }
}
