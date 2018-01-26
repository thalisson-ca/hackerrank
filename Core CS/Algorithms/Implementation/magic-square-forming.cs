using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    
    static void Main(String[] args) {
        int[][] s = new int[3][];
        for(int s_i = 0; s_i < 3; s_i++){
           string[] s_temp = Console.ReadLine().Split(' ');
           s[s_i] = Array.ConvertAll(s_temp,Int32.Parse);
        }
        
        //Middle will always be 5
        int cust = 0;
        if(s[1][1]!=5){
            cust += Math.Abs(5-s[1][1]);
            s[1][1]=5;
        }
        
        int minCheck=9999;
        //The borders nummbers will always have the sequence 8,3,4,9,2,7,6,1 clock-wise or anti-clockwise
        int[] seq = {8,3,4,9,2,7,6,1};
        for(int offset=0;offset<8;offset+=2){
            int pos = offset+8;
            //Check Clockwise
            int custClockwise=0;    
            custClockwise+=Math.Abs(seq[pos%8]-    s[0][0]);
            custClockwise+=Math.Abs(seq[(pos+1)%8]-s[0][1]);
            custClockwise+=Math.Abs(seq[(pos+2)%8]-s[0][2]);
            custClockwise+=Math.Abs(seq[(pos+3)%8]-s[1][2]);
            custClockwise+=Math.Abs(seq[(pos+4)%8]-s[2][2]);
            custClockwise+=Math.Abs(seq[(pos+5)%8]-s[2][1]);
            custClockwise+=Math.Abs(seq[(pos+6)%8]-s[2][0]);
            custClockwise+=Math.Abs(seq[(pos+7)%8]-s[1][0]);
           
            //Check Anticlockwise
            int custAntiClockwise=0;
            custAntiClockwise+=Math.Abs(seq[pos%8]-    s[0][0]);
            custAntiClockwise+=Math.Abs(seq[(pos-1)%8]-s[0][1]);
            custAntiClockwise+=Math.Abs(seq[(pos-2)%8]-s[0][2]);
            custAntiClockwise+=Math.Abs(seq[(pos-3)%8]-s[1][2]);
            custAntiClockwise+=Math.Abs(seq[(pos-4)%8]-s[2][2]);
            custAntiClockwise+=Math.Abs(seq[(pos-5)%8]-s[2][1]);
            custAntiClockwise+=Math.Abs(seq[(pos-6)%8]-s[2][0]);
            custAntiClockwise+=Math.Abs(seq[(pos-7)%8]-s[1][0]);
            
            if(custClockwise<minCheck){
                minCheck=custClockwise;
            }
            if(custAntiClockwise<minCheck){
                minCheck=custAntiClockwise;
            }
        }
         cust+=minCheck;
        //  Print the minimum cost of converting 's' into a magic square
        Console.WriteLine(cust);                

    }
}
