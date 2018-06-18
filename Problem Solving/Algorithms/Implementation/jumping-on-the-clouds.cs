using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        
        int moves=0;
        int local = 0;
        do{
            
            if((local+2)<c.Length && c[local+2]==0){
                local+=2;
            }else{
                local++;
            }
            moves++;
        }while(local!=c.Length-1);
        Console.Write(moves);
        
    }
}
