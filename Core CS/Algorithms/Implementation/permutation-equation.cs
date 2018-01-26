using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        int n = int.Parse(Console.ReadLine());
        List<string> p = Console.ReadLine().Split(' ').ToList();
        
        
        for(int i=1;i<=n;i++){
            int c =p.FindIndex(j=>j==(p.FindIndex(l=>l==i+"")+1)+"")+1;
            Console.WriteLine(c);
                        
        }
        
        
        
    }
}
}
