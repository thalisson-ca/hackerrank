using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        
        s.Replace(" ", "");
        int nLine = (int) Math.Floor(Math.Sqrt(s.Length));
        int nCol = (int)Math.Ceiling(Math.Sqrt(s.Length));
        
        if(nLine*nCol<s.Length){
            nLine++;
        }
        
        char[][] M = new char[nLine][];
        for(int i=0;i<nLine;i++){
            M[i] = s.Substring(i*nCol,Math.Min(nCol,s.Length-i*nCol)).ToCharArray();
        }
        
        for(int j=0;j<nCol;j++){
            for(int i=0;i<nLine;i++){
                if(i<M.Length && j<M[i].Length){
                    Console.Write(M[i][j]);
                }
            }
            Console.Write(" ");
        }
    }
}
