using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i=1;i<=n;i++){
            string stair = "";
            for(int j=1;j<=n;j++){
                stair+=(j<=(n-i))?" ":"#";
            }
            Console.WriteLine(stair);
        }
        
    }
}
