using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        char[] s = Console.ReadLine().ToCharArray();
        long n = Convert.ToInt64(Console.ReadLine());
        
        long repeticao = n/s.Length;
        long resto = n%s.Length;
        long countR = 0;
        long countS = 0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='a'){
              if(i<resto){
                countR++;  
              }  
              countS++;
            }
        }
        
        Console.Write(countR+(countS*repeticao));
        
    }
}
