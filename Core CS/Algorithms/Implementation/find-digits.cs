using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int pivo = n;
            int count = 0;
            do{
                int d = pivo%10;
                if(d!=0 && n%d==0){
                    count++;
                }
                pivo/=10;
            }while(pivo!=0);
            Console.WriteLine(count);
            
        }
    }
}
