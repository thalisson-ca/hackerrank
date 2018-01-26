using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        BigInteger b = new BigInteger(1);
        
        for(int i=2;i<=n;i++){
            b = BigInteger.Multiply(b,new BigInteger(i));	
        }
        
        Console.WriteLine(b.ToString());
    }
}
