using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s){
        // Complete this function
        int min = s[0];
        int max = s[0];
        
        int goodRecord = 0;
        int badRecord = 0;
        for(int i=1;i<s.Length;i++){
            if(s[i]>max){
                goodRecord++;
                max = s[i];
            }else if(s[i]<min){
                badRecord++;
                min = s[i];
            }
        }
        return new int[]{goodRecord,badRecord};
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}
