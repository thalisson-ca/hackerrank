using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        List<string> listaN = new List<string>();
        for(int i=0;i<n;i++){
            listaN.Add(Console.ReadLine());
        }
        int q = int.Parse(Console.ReadLine());
        
        for(int i=0;i<q;i++){
            string query = Console.ReadLine();
            Console.WriteLine(listaN.Count(x=>x==query));
        }
        
        
        
    }
}