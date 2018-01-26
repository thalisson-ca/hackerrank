using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        char[] s = Console.ReadLine().ToCharArray();
        char[] t = Console.ReadLine().ToCharArray();
        int k = Convert.ToInt32(Console.ReadLine());
        string response = "No";
        
        int afterLength=Math.Abs(s.Length-t.Length);
        
        if(afterLength<=k){
            if(k>=s.Length+t.Length){
                response="Yes";
            }else{
                int numberOfOperation = afterLength;
                int minSize = Math.Min(s.Length,t.Length);
                int equalEnd = 0;
                while(equalEnd<minSize && s[equalEnd]==t[equalEnd]){
                    equalEnd++;                
                }
                if(equalEnd<minSize){
                    numberOfOperation+=(minSize-equalEnd)*2;
                }
            
                if(k>=numberOfOperation && (k-numberOfOperation)%2==0){
                    response="Yes";
                }
            }
        }
       
        Console.WriteLine(response);
        
        
    }
}
